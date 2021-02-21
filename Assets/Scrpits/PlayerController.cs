using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int speed;
    Rigidbody2D bod;

    private void Awake()
    {
        bod = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            Jump();
        }

        if (Input.GetKey(KeyCode.A)){
            bod.AddForce(Vector2.left * speed);
        }

        if (Input.GetKey(KeyCode.S)){
            //bod.AddForce(Vector2.down);
        }

        if (Input.GetKey(KeyCode.D)){
            bod.AddForce(Vector2.right * speed);
        }
    }

    private void Jump()
    {
        if(bod.velocity.y < 0){
            bod.AddForce(Vector2.up * speed);
        } 
    }

}
