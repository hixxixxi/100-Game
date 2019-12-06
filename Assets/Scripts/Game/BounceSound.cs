using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
   public AudioSource bounce;




    private void OnCollisionEnter2D(Collision2D collision)
    {
        bounce.Play();
    }
}
