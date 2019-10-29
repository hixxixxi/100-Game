using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonfx : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;


    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);

    }
}
