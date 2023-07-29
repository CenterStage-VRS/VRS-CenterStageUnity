using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldControl : MonoBehaviour
{
    //For UI to interface with field managers/timers etc
    private GameTimeManager gameTime;
    private void Start()
    {
        gameTime = FindFirstObjectByType<GameTimeManager>();
        RoundReceiver round = FindFirstObjectByType<RoundReceiver>();
        GameTimeManager.instance.onPauseEv += round.SetPausedText;
        GameTimeManager.instance.onResumeEv += round.SetRoundText;
    }
    public void StartTimer()
    {
        gameTime.Play();
    }

    public void SetMode(int gameMode)
    {
        PowerPlayFieldManager.instance.SetGameMode(gameMode);
        gameTime.SetUpTimer();
    }


}
