using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHit : MonoBehaviour
{
    private bool isColliding;
    public string newLevel;
    private GameObject player;

    private void Start() {
        player = GameObject.FindWithTag("Player");
        // Physics.IgnoreLayerCollision(0, 3);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Return)) {
            if(isColliding) {
                Initiate.Fade(newLevel,Color.black,1);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player") {
            isColliding = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.name == "Player") {
            isColliding = false;
        }
    }
}
