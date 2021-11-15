using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoket : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
    void OnCollisionEnter2D(Collision2D bul)
    {
        Destroy(bul.gameObject);
    }
}
