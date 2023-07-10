using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro comboText;
    public static int comboScore;
    public static float adjScore;
    public static float HP;

    public float HPInEditor;

    public static int missCount = 0;
    public static int hitCount = 0;
    public static int maxCombo = 0;

    void Start()
    {
        HP = HPInEditor;
        Instance = this;
        comboScore = 0;
        adjScore = 0;
        hitCount = 0;
        missCount = 0;
    }

    public static void Hit()
    {
        comboScore += 1;
        hitCount += 1;
        if(comboScore <= 100) {
            adjScore += 100*comboScore;
        }
        else {
            adjScore += 100*100;
        }
        
        if(comboScore > maxCombo) {
            maxCombo = comboScore;
        }
    }

    public static void Miss()
    {
        comboScore = 0;
        missCount += 1;
    }

    void FixedUpdate()
    {
        scoreText.text = adjScore + "/" + HP + " (" + (Mathf.Round((adjScore/HP) * 100)) + "%)";
        comboText.text = comboScore + "\n COMBO!";
        //Debug.Log("Miss Count: " + missCount + ", Hit Count: " + hitCount);
        //Debug.Log("Highest Combo: " + maxCombo);
    }
}