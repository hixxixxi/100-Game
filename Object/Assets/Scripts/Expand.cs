using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Circle is expanded when left click is pressed
/// </summary>
/// 
/// Field           Description
/// isPressed       Is the object pressed
/// scaleFactor     Factor to scale the object by
/// 
/// Author: Chamod Welhenge
/// 
public class Expand : MonoBehaviour
{
    private bool isPressed = false;
    public float scaleFactor = 0.1f;

    /// <summary>
    /// Called once a frame
    /// </summary>
    private void Update()
    {
        // if left click is pressed
        if (isPressed == true) {

            // expand the object using scaleFactor
            this.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor) ;

        }
    }

    /// <summary>
    /// Run when mouse is clicked
    /// </summary>
    private void OnMouseDown()
    {
        // if left click is pressed
        if (Input.GetMouseButtonDown(0))
        {
            //  set pressed to true
            isPressed = true;

            Vector3 mousePos;
            // converts mouse position into in-gamme coordinates
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
    }

    /// <summary>
    /// Run when mouse click is released
    /// </summary>
    private void OnMouseUp() 
    {
        // Since mouse click is released
        isPressed = false;
    }
}
