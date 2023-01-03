using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHit : MonoBehaviour
{
    public string newLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        Initiate.Fade(newLevel,Color.black,1);
    }
}
