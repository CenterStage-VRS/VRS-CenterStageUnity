using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenaltyWrongColor : MonoBehaviour
{
    TeamColor objectColor, subjectColor;
    [SerializeField] ScoreTracker blueScoreTracker;
    [SerializeField] ScoreTracker redScoreTracker;

    [SerializeField] GlobalInt instantPenalty, ongoingPenalty;
    [SerializeField] int numberOfInstantPenalties, numberOfOngoingPenalties;

    // Start is called before the first frame update
    void Start()
    {
        objectColor = GetComponent<ScoreObjectTypeLink>().LastTouchedTeamColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartCheckForWrongColor(TeamColor subjectColor)
    {
        subjectColor = this.subjectColor;

        if (objectColor != subjectColor)
        {
            StartCoroutine(ContinueCheckingForWrongColor());
        }
    }

    private void Punish(TeamColor subjectColor, GlobalInt penalty, int numberOfPenalties)
    {
        switch (subjectColor)
        {
            case TeamColor.Blue:
                blueScoreTracker.AddOrSubtractScore(-penalty.globalInt * numberOfPenalties);
                break;
            case TeamColor.Red:
                redScoreTracker.AddOrSubtractScore(-penalty.globalInt * numberOfPenalties);
                break;
        }
    }

    public void EndCheckForWrongColor()
    {
        StopCoroutine(ContinueCheckingForWrongColor());
    }

    IEnumerator ContinueCheckingForWrongColor()
    {
        int penaltyCount = 0;
        while (true)
        {
            if (penaltyCount < 1)
                Punish(subjectColor, instantPenalty, numberOfInstantPenalties);
            else 
                Punish(subjectColor, ongoingPenalty, numberOfOngoingPenalties);
            yield return new WaitForSeconds(5);
        }
    }
}
