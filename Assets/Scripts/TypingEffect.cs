using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypingEffect : MonoBehaviour {
    public float delay = 0.1f;
    public string text;
    private string currentText = " ";

    public TextMeshProUGUI textObject;
    public AudioSource textSound;
    public GameObject dialogueBox;

    private bool isColliding;
    private bool inUse = false;
    public GameObject player;

    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Return)) {
            if(isColliding && !inUse) {
                StartCoroutine(showText(text + "      ."));
                inUse = true;
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

    public IEnumerator showText(string displayText) {
        player.GetComponent<PlayerController>().enabled = false;
        dialogueBox.SetActive(true);
        textSound.Play();
        for(int i = 0; i < displayText.Length; i++) {
            currentText = displayText.Substring(0,i);
            textObject.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        textSound.Pause();
        dialogueBox.SetActive(false);
        player.GetComponent<PlayerController>().enabled = true;
        inUse = false;
    }
}