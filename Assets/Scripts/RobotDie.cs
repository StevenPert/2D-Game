using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDie : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            
        }
        else
        {
            if (other.gameObject.name.Contains("Player")) Destroy(other.gameObject);
            
        }


    }
}