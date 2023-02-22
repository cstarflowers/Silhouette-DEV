using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro comboText;
    static int comboScore;
    static float adjScore;
    public float HPInEditor;
    static float HP;

    static int missCount = 0;
    static int hitCount = 0;
    static int maxCombo = 0;

    void Start()
    {
        HP = HPInEditor;
        Instance = this;
        comboScore = 0;
        adjScore = 0;
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
        // print(adjScore + "/" + HP + " = " + (Mathf.Round((adjScore/HP) * 100)) + "%");
        // scoreText.text = adjScore.ToString();
        Debug.Log("Miss Count: " + missCount + ", Hit Count: " + hitCount);
        Debug.Log("Highest Combo: " + maxCombo);

        //if(adjScore >= HP) {
            
        //}
    }
}