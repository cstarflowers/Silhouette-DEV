using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

public float speed;
public Rigidbody2D player;

public void Update()
{
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    Vector3 tempVect = new Vector3(h, v, 0);
    tempVect = tempVect.normalized * (1000*speed) * Time.deltaTime;
    player.MovePosition(player.transform.position + tempVect);
}
}