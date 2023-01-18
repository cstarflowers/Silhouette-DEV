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
        // Physics.IgnoreLayerCollision(0, 3);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player" && Input.GetKeyDown(KeyCode.Return)) {
            Initiate.Fade(newLevel,Color.black,1);
        }
    }
}
