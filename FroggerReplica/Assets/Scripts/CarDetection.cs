using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDetection : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(collision.gameObject);
        }
    }
}
