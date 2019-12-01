using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeScript : MonoBehaviour
{
    public Sprite[] bg;
    public int currentIndex = 0;
    public Image image;

    public void next() {

        currentIndex++;
        if (currentIndex >= bg.Length)
        {
            currentIndex = 0;
        }
        image.sprite = bg[currentIndex];
        TargetGenerator.bgIn = image.sprite;

    }


    public void prev()
    {
        currentIndex--;
        if(currentIndex < 0)
        {
            currentIndex = bg.Length - 1;

        }
        image.sprite = bg[currentIndex];
        TargetGenerator.bgIn = image.sprite;
    }

}
