using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

public float speed;
public Rigidbody2D player;
private Animator _animator;

void Start() {
    _animator = GetComponent<Animator>();
}

public void Update()
{
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    Vector3 tempVect = new Vector3(h, v, 0);
    tempVect = tempVect.normalized * speed * Time.deltaTime;
    player.MovePosition(player.transform.position + tempVect);

    _animator.SetBool("walkingLeft", h < 0);
    _animator.SetBool("walkingRight", h > 0);
    _animator.SetBool("walkingForward", v < 0);
    _animator.SetBool("walkingBackward", v > 0);
}
}