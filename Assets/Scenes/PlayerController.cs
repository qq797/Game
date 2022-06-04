using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public float jumpAmount = 10;

    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.20f);
        }
        if (Input.GetKey(moveDown))
        {
            transform.position = transform.position + new Vector3(0, 0, -0.20f);
        }
        if (Input.GetKey(moveLeft))
        {
            transform.position = transform.position + new Vector3(-0.20f, 0, 0);
        }
        if (Input.GetKey(moveRight))
        {
            transform.position = transform.position + new Vector3(0.20f, 0, 0);
        }
        if (Input.GetKey(moveJump))
        {
            transform.position = transform.position + new Vector3(0, 0.20f, 0);
        }
    }
}