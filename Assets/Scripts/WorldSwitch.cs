using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSwitch : MonoBehaviour {

public Rigidbody2D player;

public string newLevel;

void Update() {
    string sceneName = SceneManager.GetActiveScene().name.ToString();

    if(Input.GetKeyDown(KeyCode.R) && sceneName == "BrainWorld") {
        PlayerController.animator.Play("Headphones");
        player.GetComponent<PlayerController>().enabled = false;

        PlayerController.direction = new Vector2(0,0);
        player.velocity = new Vector2(0,0);

        PlayerController.animator.SetBool("walkingLeft", false);
        PlayerController.animator.SetBool("walkingRight", false);
        PlayerController.animator.SetBool("walkingForward", false);
        PlayerController.animator.SetBool("walkingBackward", false);

        StartCoroutine(musicTeleport(1));    
    }
}

IEnumerator musicTeleport(float delay) {
    yield return new WaitForSeconds(delay);
    Initiate.Fade(newLevel,Color.black,30);
}
}