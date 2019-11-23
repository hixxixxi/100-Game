using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public void MuteAudio() {
        AudioListener.pause = !AudioListener.pause;
    }
}
