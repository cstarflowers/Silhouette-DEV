using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

public float speed;
private Rigidbody2D player;
private Animator animator;
private Vector2 direction;

void Start() {
    animator = GetComponent<Animator>();
    player = GetComponent<Rigidbody2D>();

    player.constraints = RigidbodyConstraints2D.FreezeRotation;
}

public void Update()
{
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    direction = new Vector2(h,v);
    animator.SetBool("walkingLeft", h < 0);
    animator.SetBool("walkingRight", h > 0);
    animator.SetBool("walkingForward", v < 0);
    animator.SetBool("walkingBackward", v > 0);
}

void FixedUpdate() {
    player.velocity = direction * speed;
}
}