using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

public float speed;
private Rigidbody2D player;
public static Animator animator;
public static Vector2 direction;

void Start() {
    Application.targetFrameRate = 60;
    animator = GetComponent<Animator>();
    player = GetComponent<Rigidbody2D>();

    player.constraints = RigidbodyConstraints2D.FreezeRotation;
}

public void Update()
{
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    // direction = new Vector2(h,v);

    animator.SetBool("walkingLeft", h < 0);
    animator.SetBool("walkingRight", h > 0);
    animator.SetBool("walkingForward", v < 0);
    animator.SetBool("walkingBackward", v > 0);

    if(h != 0 && !(animator.GetBool("walkingForward") || animator.GetBool("walkingBackward"))) {
        direction = new Vector2(h,0);
    }
    else if(v != 0 && !(animator.GetBool("walkingLeft") || animator.GetBool("walkingRight"))) {
        direction = new Vector2(0,v);
    }
}

void FixedUpdate() {
    player.velocity = direction * speed;
}
}