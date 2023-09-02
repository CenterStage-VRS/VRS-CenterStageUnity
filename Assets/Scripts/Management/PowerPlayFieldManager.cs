using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using UnityEngine.Events;
using Photon.Pun;
using Photon.Realtime;

public enum GameMode
{
    Autonomous=0,
    Teleop=1,
    Fullgame=2,
    Freeplay=3
}


public class PowerPlayFieldManager : FieldManager
{
    public GameMode mode;

    public GameTimeManager gameTimeManager;

    public SelectBotOptions select;

    private static PowerPlayFieldManager _instance;
    public static PowerPlayFieldManager instance
    {
        get { return _instance; }
    }

    [SerializeField] GlobalInt currentSession;

    

    public UnityEvent onResetField;
    public UnityEvent onStartMP;

    [DllImport("__Internal")]
    private static extern void updateSignalSensor(int signal);
    private bool hasCheckedSignalSensor = false;
    int currentGameMode = 0;

    PowerPlayFieldManager()
    {
        if (_instance != null && _instance != this)
        {
            //Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
        else
        {
            _instance = this;
        }
    }

    public void Start()
    {
        base.Start();
#if !UNITY_EDITOR
        GameMode mode = GameMode.Teleop;
        if (vrs_messenger.instance == null)
        {
            mode = GameMode.Teleop;
        }
        else
        {
            mode = (GameMode)vrs_messenger.instance.GetPlaymode();
        }

        if(mode == GameMode.Autonomous)
        {
            SetGameMode((int)mode);
        }
        
#endif

        GameTimeReceiver timeReceiver = FindObjectOfType<GameTimeReceiver>();

        //SetGameMode(0);
    }
    [PunRPC]
    public override void StartMPGame()
    {
        base.StartMPGame();
        //how to send settings here?
        //if (PhotonNetwork.IsMasterClient)
        {
            
            //SetGameType(MultiplayerSetting.multiplayerSetting.getGameType());
            SetGameMode(MultiplayerSetting.multiplayerSetting.getGameType());
            gameTimeManager.SetUpTimer();
            PhotonView v = GetComponent<PhotonView>();
            Player[] p = PhotonNetwork.PlayerList;
            for(int i = 0; i < MultiplayerSetting.multiplayerSetting.playerList.Length; i++)
            {
                if (MultiplayerSetting.multiplayerSetting.playerList[i] != -1)
                {
                    PhotonView view = PhotonNetwork.GetPhotonView(MultiplayerSetting.multiplayerSetting.playerList[i]);
                    //Players Spawned in PhotonRoom

                }
            }

            SelectBotOptions.autostartMP = true;
            
        }
    }

    void Update()
    {
        if(!hasCheckedSignalSensor)
            checkSignalSensor();
    }
    void checkSignalSensor()
    {
        int signalType = 0;
        GameObject signalConeParent = null;
        SignalRandomizer rand = FindObjectOfType<SignalRandomizer>();
        if (!signalConeParent) { return; }
        signalConeParent = rand.gameObject;
        foreach(Transform child in signalConeParent.transform)
        {
            signalType++;
            if(child.gameObject.activeInHierarchy)
                break;
        }
#if UNITY_WEBGL && !UNITY_EDITOR
        try{updateSignalSensor(signalType);}
        catch{}
#endif

        hasCheckedSignalSensor = true;
    }

    [PunRPC]
    protected override void SetGameType(string type)
    {
        SetGameMode(1);
    }
    public void ResetToExistingGameMode()
    {
        SetGameMode(currentGameMode);
    }

    public void resetField()
    {
        onResetField.Invoke();
    }

    public void autoResetFieldToo()
    {
        OnAutoReset();
        onResetField.Invoke();
        //this.autoResetField();
    }

    public void SetupCustomBot(string customName, GameObject baseObj)
    {

    }

    
    public void SetGameMode(int mode)
    {
        Debug.Log("Setting Game Mode : " + (GameMode)mode);
        currentGameMode = mode;

        Session autonomous = gameTimeManager.sessions[0];
        Session teleOpMid = gameTimeManager.sessions[1];
        Session teleOpEnd = gameTimeManager.sessions[2];
        Session freePlay = gameTimeManager.sessions[3];
        Session gameOver = gameTimeManager.sessions[4];

        switch(mode)
        {
            case (int)GameMode.Autonomous:
                autonomous.PlayThisSession = true;
                teleOpMid.PlayThisSession = false;
                teleOpEnd.PlayThisSession = false;
                freePlay.PlayThisSession = false;
                gameOver.PlayThisSession = true;
                break;
            case (int)GameMode.Teleop:
                autonomous.PlayThisSession = false;
                teleOpMid.PlayThisSession = true;
                teleOpEnd.PlayThisSession = true;
                freePlay.PlayThisSession = false;
                gameOver.PlayThisSession = true;
                break;
            case (int)GameMode.Fullgame:
                autonomous.PlayThisSession = true;
                teleOpMid.PlayThisSession = true;
                teleOpEnd.PlayThisSession = true;
                freePlay.PlayThisSession = false;
                gameOver.PlayThisSession = true;
                break;
            case (int)GameMode.Freeplay:
                autonomous.PlayThisSession = false;
                teleOpMid.PlayThisSession = false;
                teleOpEnd.PlayThisSession = false;
                freePlay.PlayThisSession = true;
                gameOver.PlayThisSession = false;
                break;
        }

    }

}
