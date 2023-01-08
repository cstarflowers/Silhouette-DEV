using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer hitCircle;
    public Sprite defaultImage;
    public Sprite pressedImage;

    // public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        hitCircle = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            hitCircle.sprite = pressedImage;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            hitCircle.sprite = pressedImage;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            hitCircle.sprite = pressedImage;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)) {
            hitCircle.sprite = pressedImage;
        }

        if(Input.GetKeyUp(KeyCode.UpArrow)) {
            hitCircle.sprite = defaultImage;
        }
        else if(Input.GetKeyUp(KeyCode.DownArrow)) {
            hitCircle.sprite = defaultImage;
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow)) {
            hitCircle.sprite = defaultImage;
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow)) {
            hitCircle.sprite = defaultImage;
        }
    }
}