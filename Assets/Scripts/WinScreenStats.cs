using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreenStats : MonoBehaviour {
    public TMPro.TextMeshPro statusText;
    public TMPro.TextMeshPro hitText;
    public TMPro.TextMeshPro missText;
    public TMPro.TextMeshPro scoreText;

    void Start() {
        //if(ScoreManager.adjScore > ScoreManager.HP) {
        //    statusText.text = "You win!";
        Debug.Log("WinScreenStats is not functional. Please fix!");
        //}
    }
}