using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBotOptions : MonoBehaviour
{
    public List<GameObject> botPrefabs = new List<GameObject>();
    TeamColor color = TeamColor.Blue;
    int selectedBot = 0;
    bool useLowerSpawn = false;

    public List<Transform> spawnPoints = new List<Transform>();
    // Start is called before the first frame update

    public void SelectBot(int index)
    {
        selectedBot = index;
    }

    public void SetSpawn(bool useLower)
    {
        useLowerSpawn = useLower;
    }

    public void SelectColor(int index)
    {
        color = (TeamColor)index;
    }

    public void StartGame()
    {
        int spawnIdx = (int)color;
        if (useLowerSpawn) { spawnIdx += 2; }
        GameObject bot = GameObject.Instantiate(botPrefabs[selectedBot],spawnPoints[spawnIdx].position, spawnPoints[spawnIdx].rotation);
        bot.GetComponent<ColorSwitcher>().TeamColor_ = color;
        bot.GetComponent<ColorSwitcher>().SetColor();
        bot.GetComponent<ScoreObjectTypeLink>().LastTouchedTeamColor = color;
    }

}