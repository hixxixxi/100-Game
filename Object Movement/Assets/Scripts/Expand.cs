using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Expand the object when the mouse is hovered over
/// </summary>
/// 
/// Source: https://stackoverflow.com/questions/20583653/raycasting-to-find-mouseclick-on-object-in-unity-2d-games
/// 
/// Field           Description
/// scaleFactor     Factor to scale the object by
/// 
/// Author: Chamod Welhenge
/// 
public class Expand : MonoBehaviour
{
    public float scaleFactor = 0.01f;

    // Update is called once per frame
    void Update()
    {
        // mouse position converted into a vector2 in game coordinates
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // cast a ray
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
        // if ray hit something
        if (hit.collider != null)
        {
                // scale that something up by the scaleFactor
                hit.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);          
        }
    }
}
