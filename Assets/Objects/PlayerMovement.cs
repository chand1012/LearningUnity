using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const int movementSpeed = 5;
    private const int jumpVelocity = 10;
    private const float jumpDuration = 0.1f;
    private float jumpTimer = 0.0f;
    private bool canJump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        // jump
        var jump = Input.GetButton("Jump");

        if (jump && canJump)
        {
            jumpTimer = Time.time + jumpDuration;
            canJump = false;
        }

        if (jumpTimer > Time.time && !canJump)
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * jumpVelocity;
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            canJump = true;
        }
    }


}
