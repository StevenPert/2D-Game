using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{

    void OnCollsionEnter2D(Collision2D collision)
    {
        
        {
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;

        }

    }
}