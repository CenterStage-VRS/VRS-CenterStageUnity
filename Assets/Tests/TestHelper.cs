using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TestHelper
{
    public static Dictionary<string, ScoreTracker> scores = new Dictionary<string, ScoreTracker>();
    public static SelectBotOptions botOptions;
    public static GameObject[,] gameGrid;
    static int gridHeight = 5;
    static int gridWidth = 5;
    public static JunctionCapper[] scoringLocs;
    public static string testPattern = "A0,B1,C2,D3,E4";

    public static GameObject getGoalOnGrid(string coords)
    {
        Vector2Int loc = getGridLocation(coords);
        return gameGrid[loc.x, loc.y];
    }

    public static Vector2Int getGridLocation(string coords)
    {
        int acode = (int)'A';
        int column = (int)coords[0];
        column -= acode;
        return new Vector2Int(column, int.Parse(coords[1].ToString()));
    }

    public static void setGoalOnGrid(string coords, GameObject obj)
    {
        Vector2Int loc = getGridLocation(coords);
        gameGrid[loc.x, loc.y] = obj;
    }

    public static void CreateGrid()
    {

        scoringLocs = GameObject.FindObjectsOfType<JunctionCapper>();
        foreach (JunctionCapper cap in scoringLocs)
        {
            string coords = cap.transform.parent.parent.parent.name.Split('-')[1];//need a 
            setGoalOnGrid(coords, cap.gameObject);
        }
    }

    public static void ReadyTest()//this needs to be called after scene is ready, which is why its not in setup.
    {

        ScoreTracker[] trackers = Resources.LoadAll<ScoreTracker>("");
        scores.Clear();
        foreach (ScoreTracker tracker in trackers)
        {
            if (tracker.name.Contains("Red"))
            {
                scores.Add("Red", tracker);
            }
            else
            {
                scores.Add("Blue", tracker);
            }
        }
        gameGrid = new GameObject[gridWidth, gridHeight];

        CreateGrid();

        SelectBotOptions botgui = GameObject.FindObjectOfType<SelectBotOptions>();
        if (botgui) { botgui.gameObject.SetActive(false); }

    }
}