using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minSpeed = 4f;
    public  float maxspeed = 20f;

    float speed = 1f;

    private void Start()
    {
        
      speed = Random.Range(minSpeed, maxspeed);
    }
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
 
    }

    public void changeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void changeMinSpeed(float newMinSpeed)
    {
        minSpeed = newMinSpeed;   
    }

    public void changeMaxSpeed(float newMaxSpeed)
    {
        maxspeed = newMaxSpeed;
    }
}

