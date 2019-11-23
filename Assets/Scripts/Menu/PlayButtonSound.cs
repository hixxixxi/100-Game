using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonSound : MonoBehaviour
{

    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    bool LoadingInitiated = false;

    public void OnMouseDown() {
        if (!LoadingInitiated) {
            StartCoroutine(DelayedLoad());
            LoadingInitiated = true;
        }
    }
    IEnumerator DelayedLoad()
    {
        myFx.PlayOneShot(clickFx);
        //Wait until clip finish playing
        yield return new WaitForSeconds(clickFx.length);
        //Load new scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}