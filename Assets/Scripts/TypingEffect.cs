using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypingEffect : MonoBehaviour {
    public float delay = 0.05f;
    private string currentText = " ";

    public string[] textArray;

    public TextMeshProUGUI textObject;
    public AudioSource textSound;
    public GameObject dialogueBox;

    private bool isColliding;
    private bool inUse = false;
    private int onText = 0;
    public GameObject player;

    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) {
            if(isColliding && !inUse) {
                if(textArray[onText].ToString() == "STOP") {
                    dialogueBox.SetActive(false);
                    player.GetComponent<PlayerController>().enabled = true;
                    onText = 0;
                }
                if(textArray[onText].ToString() == "GOTO NEXT") {
                    dialogueBox.SetActive(false);
                    player.GetComponent<PlayerController>().enabled = true;
                    Initiate.Fade(textArray[onText+1].ToString(),Color.black,30);
                    onText = 0;
                }
                else if(textArray[onText].ToString() != "STOP" && textArray[onText].ToString() != "GOTO NEXT") {
                    currentText = " ";
                    StartCoroutine(showText(textArray[onText]));
                    onText += 1;
                }
            }
        }
    }

    public IEnumerator showText(string displayText) {
        inUse = true;
        player.GetComponent<PlayerController>().enabled = false;
        dialogueBox.SetActive(true);
        textSound.Play();
        for(int i = 0; i < displayText.Length; i++) {
            currentText = displayText.Substring(0,i);
            textObject.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        textSound.Pause();
        inUse = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player") {
            isColliding = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.name == "Player") {
            isColliding = false;
            dialogueBox.SetActive(false);
            player.GetComponent<PlayerController>().enabled = true;
            onText = 0;
        }
    }
}