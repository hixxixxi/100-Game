using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceMusic : MonoBehaviour
{
    AudioSource au;
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        au.Play();
    }
}
