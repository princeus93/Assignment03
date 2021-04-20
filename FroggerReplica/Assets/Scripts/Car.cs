using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minSpeed = 10f;
    public  float maxSpeed = 15f;
   //float newMinSpeed, newMaxSpeed;


   public float speed = 1f;
    private PlayerSettings ps;

    private void Start()
    {
        //minSpeed = ps.minSpeed;
       // maxSpeed = ps.maxSpeed;
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

    public void changeSpeed(float newSpeed)
    {
       // ps.speed = newSpeed;
        speed = newSpeed;
    }
    
    public void changeMinSpeed(float newMinSpeed)
    {
        //newMinSpeed = ps.minSpeed;
        minSpeed = newMinSpeed; 
    }

    public void changeMaxSpeed(float newMaxSpeed)
    {
        //newMaxSpeed = ps.maxSpeed;
        maxSpeed = newMaxSpeed;
    }
}

