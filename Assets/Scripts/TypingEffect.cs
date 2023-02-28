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
    public Rigidbody2D player;

    private PlayerController playerController;

    void Start() {
        // player = GameObject.FindWithTag("Player");
        playerController = player.GetComponent<PlayerController>();

    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) {
            if(isColliding && !inUse) {
                if(onText == -1) {
                    onText = 0;
                }
                else if(textArray[onText].ToString() == "STOP") {
                    textSound.Stop();
                    dialogueBox.SetActive(false);
                    playerController.enabled = true;
                    onText = -1;
                }
                else if(textArray[onText].ToString() == "GOTO NEXT") {
                    textSound.Stop();
                    dialogueBox.SetActive(false);
                    playerController.enabled = true;
                    Initiate.Fade(textArray[onText+1].ToString(),Color.black,30);
                    onText = 0;

                }
                else if(textArray[onText].ToString() != "STOP" && textArray[onText].ToString() != "GOTO NEXT") {
                    StartCoroutine(showText(textArray[onText]));
                    onText += 1;
                }
            }
        }
    }

    public IEnumerator showText(string displayText) {
        inUse = true;
        disableMovement();
        currentText = " ";
        dialogueBox.SetActive(true);
        textSound.Play();
        for(int i = 0; i <= displayText.Length; i++) {
            currentText = displayText.Substring(0,i);
            textObject.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        textSound.Stop();
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
            playerController.enabled = true;
            onText = 0;
        }
    }

    void disableMovement() {
        playerController.enabled = false;
        
        PlayerController.direction = new Vector2(0,0);
        player.velocity = new Vector2(0,0);

        PlayerController.animator.SetBool("walkingLeft", false);
        PlayerController.animator.SetBool("walkingRight", false);
        PlayerController.animator.SetBool("walkingForward", false);
        PlayerController.animator.SetBool("walkingBackward", false);
    }
}