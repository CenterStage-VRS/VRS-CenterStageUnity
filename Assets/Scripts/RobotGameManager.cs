using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RobotGameManager : MonoBehaviour
{
    [SerializeField] GameObject robot;
    [SerializeField] GameObject[] objectsToSpawnInWarehouse;
    [SerializeField] int[] numObjectsToSpawn;

    [SerializeField] GameObject duck;
    [SerializeField] Transform[] blueTeamDuckSpawns, redTeamDuckSpawns;
    [SerializeField] Transform blueSpawn, redSpawn;
    [SerializeField] Transform blueItemSpawn, redItemSpawn;
    public Transform redCarouselDuckSpawn, blueCarouselDuckSpawn;

    [SerializeField] Transform objectHolder;
    List<GameObject> spawnedItems;

    [SerializeField] float itemOffset;

    public Action GameStart;
    public Action GameOver;

    ScoreKeeper scoreKeeper;

    AudioManager audioManager;

    bool gameStarted,roundStarted,gameOver;

    [SerializeField]TextMeshProUGUI timerText, roundNumText;

    float roundTimer;
    [SerializeField] float[] roundTimes;
    [SerializeField] float delayBetweenRounds = 5f;

    int currentRound = 0;
    [SerializeField] int maxRounds = 3;


    static RobotGameManager _rg;

    public static RobotGameManager rg
    {
        get
        {
            return _rg;
        }
    }

    private void Awake()
    {
        _rg = this;

        if (!scoreKeeper)
        {
            scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>();
        }
        audioManager = FindObjectOfType<AudioManager>();

        timerText.text = "-:--";
    }

    void Start()
    {
        spawnedItems = new List<GameObject>();
        SpawnRobots();
    }

    private void Update()
    {
        if (roundStarted)
        {
            if (roundTimer > 0)
            {
                roundTimer -= Time.deltaTime;

                if (((roundTimer % 60) < 10)) timerText.text = (int)(roundTimer / 60) + ":0" + (int)(roundTimer % 60);
                else timerText.text = (int)(roundTimer / 60) + ":" + (int)(roundTimer % 60);
            }
            else
            {
                timerText.text = "0:00";
                EndRound();
            }
        }
    }

    void StartRound()
    {

        if (!gameOver)
        {
            FindObjectOfType<CountDownText>().CountDown();

            roundTimer = roundTimes[currentRound - 1];

            if (((roundTimer % 60) < 10)) timerText.text = (int)(roundTimer / 60) + ":0" + (int)(roundTimer % 60);
            else timerText.text = (int)(roundTimer / 60) + ":" + (int)(roundTimer % 60);

            roundNumText.text = "Round: " + currentRound;
            switch (currentRound)
            {
                case 1:
                    StartCoroutine(DelayBeforeFirstRoundStart());
                    break;
                case 2:
                    StartCoroutine(DelayBeforeSecondRoundStart());
                    break;
                case 3:
                    StartCoroutine(DelayBeforeFinalRoundStart());
                    break;
            }
        }
    }

    void IncrementRound()
    {
        if (currentRound < maxRounds)
        {

            currentRound++;
            StartRound();
        }
        else
        {
            EndGame();
        }
    }

    IEnumerator DelayBeforeFirstRoundStart()
    {
        SpawnRandomDucks();
        SpawnWarehouseItems();

        RobotController[] robots = FindObjectsOfType<RobotController>();
        if(currentRound == 0)foreach (RobotController robot in robots) robot.ReturnToStart();

        audioManager.playCountDown();
        yield return new WaitForSeconds(3f);

        foreach (RobotController robot in robots) robot.ActivateRobot();

        audioManager.playStartAuto();
        roundStarted = true;
    }

    IEnumerator DelayBeforeSecondRoundStart()
    {
        SpawnRandomDucks();
        SpawnWarehouseItems();

        RobotController[] robots = FindObjectsOfType<RobotController>();
        foreach (RobotController robot in robots) robot.ReturnToStart();

        audioManager.playCountDown2();
        yield return new WaitForSeconds(3f);

        foreach (RobotController robot in robots) robot.ActivateRobot();

        audioManager.playStartTeleop();
        roundStarted = true;
    }

    IEnumerator DelayBeforeFinalRoundStart()
    {
        SpawnRandomDucks();
        SpawnWarehouseItems();

        RobotController[] robots = FindObjectsOfType<RobotController>();
        foreach (RobotController robot in robots) robot.ReturnToStart();

        audioManager.playCountDown2();
        yield return new WaitForSeconds(3f);

        foreach (RobotController robot in robots) robot.ActivateRobot();

        audioManager.playStartEndGame();
        roundStarted = true;
    }

    void EndRound()
    {
        audioManager.playEndMatch();

        roundStarted = false;

        StartCoroutine(DelayBetweenRounds());
    }

    IEnumerator DelayBetweenRounds()
    {
        yield return new WaitForSeconds(delayBetweenRounds);

        IncrementRound();
    }

    void SpawnRobots()
    {
        Instantiate(robot, blueSpawn.position, blueSpawn.rotation);
    }

    void SpawnRandomDucks()
    {
        int spawnIndex = UnityEngine.Random.Range(0, 3);

        SpawnItem(duck, blueTeamDuckSpawns[spawnIndex].position);
        SpawnItem(duck, redCarouselDuckSpawn.position);
        SpawnItem(duck, redTeamDuckSpawns[spawnIndex].position );
        SpawnItem(duck, blueCarouselDuckSpawn.position);
    }

    void DestroySpawnedObjects()
    {
        for (int i = 0; i < spawnedItems.Count; i++)
        {
            Destroy(spawnedItems[i]);
        }

        spawnedItems = new List<GameObject>();

        rotateCarousel[] carousels = FindObjectsOfType<rotateCarousel>();

        for (int i = 0; i < carousels.Length; i++)
        {
            carousels[i].hasDuck = false;
        }
    }

    public void SpawnNewDuck(Transform carousel)
    {
        SpawnItem(duck, carousel.position);
    }

    void SpawnWarehouseItems()
    {
        DestroySpawnedObjects();

        for (int i = 0; i < objectsToSpawnInWarehouse.Length; i++)
        {
            for (int j = 0; j < numObjectsToSpawn[i]; j++)
            {
                Vector3 offset = new Vector3(UnityEngine.Random.Range(-itemOffset, itemOffset), 0, UnityEngine.Random.Range(-itemOffset, itemOffset));
                SpawnItem(objectsToSpawnInWarehouse[i], blueItemSpawn.position + offset);
            }
        }

        for (int i = 0; i < objectsToSpawnInWarehouse.Length; i++)
        {
            for (int j = 0; j < numObjectsToSpawn[i]; j++)
            {
                Vector3 offset = new Vector3(UnityEngine.Random.Range(-itemOffset, itemOffset), 0, UnityEngine.Random.Range(-itemOffset, itemOffset));
                SpawnItem(objectsToSpawnInWarehouse[i], redItemSpawn.position + offset);
            }
        }
    }

    public void StartGame()
    {
        if (gameStarted) return;

        if(GameStart != null)GameStart();


        GameObject.FindGameObjectWithTag("JointHub").BroadcastMessage("Reset");
        GameObject.FindGameObjectWithTag("RedHub").BroadcastMessage("Reset");
        GameObject.FindGameObjectWithTag("BlueHub").BroadcastMessage("Reset");
        GameObject[] g = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject G in g) { G.BroadcastMessage("Reset"); }

        scoreKeeper.resetScore();
        gameStarted = true;

        IncrementRound();
    }

    public void EndGame()
    {
if (!gameStarted) audioManager.playEndMatch();

        gameStarted = false;
        gameOver = true;

        GameOver();

        foreach (GameObject obj in spawnedItems)
        {
            Destroy(obj);
        }
    }

    void SpawnItem(GameObject objToSpawn,Vector3 pos)
    {
        spawnedItems.Add(Instantiate(objToSpawn, pos, objToSpawn.transform.rotation, objectHolder));
    }
}
