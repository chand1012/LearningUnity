using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public bool harmPlayer = false;
    public float dx = 0.0f;
    public float dy = 0.0f;
    //private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        //rigidBody = GetComponents<Rigidbody2D>()[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(dx, dy, 0) * Time.deltaTime * movementSpeed;
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(Bullet);
    }

    public void SetVelocity(float deltaX, float deltaY)
    {
        dx = deltaX;
        dy = deltaY;
    }
}
