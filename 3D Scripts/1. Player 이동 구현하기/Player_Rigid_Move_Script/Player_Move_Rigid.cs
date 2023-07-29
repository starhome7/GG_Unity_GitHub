using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Rigid : MonoBehaviour
{
    public Rigidbody player_rigidbody;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player_rigidbody.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player_rigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player_rigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player_rigidbody.AddForce(0f, 0f, -speed);
        }
    }

}
