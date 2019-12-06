using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeScript : MonoBehaviour
{

    public Sprite[] circles;
    public GameObject[] sprites;
    public Sprite[] bg; // image array to show
    public int currentIndex = 0; // current image being shown
    public Image image; // image being displayed
    public Image circle;


    public void next() {

        currentIndex++;
        if (currentIndex >= bg.Length)
        {
            currentIndex = 0;
        }
        image.sprite = bg[currentIndex];
        circle.sprite = circles[currentIndex];
    }


    public void prev()
    {
        currentIndex--;
        if(currentIndex < 0)
        {
            currentIndex = bg.Length - 1;

        }
        image.sprite = bg[currentIndex];
        circle.sprite = circles[currentIndex];
    }


    public void apply() {
        image.sprite = bg[currentIndex];
        circle.sprite = circles[currentIndex];
        TargetGenerator.bgIn = image.sprite;
        TargetGenerator.myPrefab = sprites[currentIndex];

    }

}
