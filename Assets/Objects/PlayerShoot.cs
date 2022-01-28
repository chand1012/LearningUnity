using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    private Vector3 playerPos;
    private Vector3 playerSize;
    private float lastPress = -1f;
    private float shootWait = 1f;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponents<Rigidbody2D>()[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time >= lastPress + shootWait)
        {
            lastPress = Time.time;
            playerPos = rigidBody.position;
            playerSize = new Vector3(10, 10, 0);
            var bulletPos = playerPos + playerSize;
            var boolet = Instantiate(Bullet, playerPos, Quaternion.identity);
            // boolet.dx = 100;
        }
    }
}
