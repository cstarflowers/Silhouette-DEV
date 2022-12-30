using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TMPro.TextMeshPro scoreText;
    static int comboScore;
    void Start()
    {
        Instance = this;
        comboScore = 0;
    }
    public static void Hit()
    {
        comboScore += 1;
    }
    public static void Miss()
    {
        comboScore = 0;
    }
    private void Update()
    {
        scoreText.text = comboScore.ToString();
    }
}