using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TMPro.TextMeshPro scoreText;
    static int comboScore;
    static int failMulti;
    static int adjScore;

    void Start()
    {
        Instance = this;
        comboScore = 0;
        adjScore = 0;
        failMulti = 1;
    }

    public static void Hit()
    {
        comboScore += 1;
        if(comboScore <= 100) {
            adjScore += 100*comboScore;
        }
        else {
            adjScore += 100*100;
        }
        if(failMulti > 1) {
            failMulti -= 1;
        }
    }

    public static void Miss()
    {
        comboScore = 0;
        if(adjScore - (100*failMulti) >= 0) {
            adjScore -= (100 * failMulti);
            if(failMulti <= 100) {
                failMulti += Random.Range(1, 5);
            }
            else {
                failMulti = 1;
            }
        }
        else {
            adjScore = 0;
            failMulti = 1;
        }
    }

    private void Update()
    {
        scoreText.text = adjScore.ToString();
        // print("adjScore = " + adjScore.ToString());
        // print("failMulti = " + failMulti.ToString());
    }
}