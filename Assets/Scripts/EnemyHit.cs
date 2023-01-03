using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHit : MonoBehaviour
{
    public string newLevel;
    private GameObject player;

    private void Start() {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player") {
            Initiate.Fade(newLevel,Color.black,1);
        }
    }
}
