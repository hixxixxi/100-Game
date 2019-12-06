 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteGame : MonoBehaviour
{
    public void MuteGameAudio()
    {
        AudioListener.pause = !AudioListener.pause; 
    }
}

