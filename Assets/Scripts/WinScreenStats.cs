using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreenStats : MonoBehaviour {
    public TMPro.TextMeshProUGUI statusText;
    public TMPro.TextMeshProUGUI hitText;
    public TMPro.TextMeshProUGUI missText;
    public TMPro.TextMeshProUGUI scoreText;

    void Start() {
        if(ScoreManager.adjScore > ScoreManager.HP) {
            statusText.text = "You win!";
        }
        else {
            statusText.text = "You lose!";
        }
        hitText.text = ScoreManager.hitCount.ToString() + " Hit!";
        missText.text = ScoreManager.missCount.ToString() + " Miss!";
        scoreText.text = "Score: " + ScoreManager.adjScore.ToString() + "\n[CLICK] to continue.";

    }
}