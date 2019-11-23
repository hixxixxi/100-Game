using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects touches on Circles and expands them
/// </summary>
public class TouchInput : MonoBehaviour
{
    public float scaleFactor = 0.01f;

    /// <summary>
    /// Detects touches on Circles and expands them
    /// </summary>
    void Update()
    {
        // loop through all touches
        for (int i = 0; i < Input.touchCount; i++)
        {
            // get touch from touch array
            Touch t = Input.touches[i];
            // convert to game world coordinates
            Vector2 tPosition = Camera.main.ScreenToWorldPoint(t.position);
            RaycastHit2D hit;
            // cast  a ray
            hit = Physics2D.Raycast(tPosition, Vector2.zero);

            // Check if object touched is a circle

            if (hit.collider.tag == "Circle")
            {
                Bounce expanding = hit.collider.gameObject.GetComponent<Bounce>();
                
                switch (t.phase)
                {
                    case TouchPhase.Began:
                        expand(hit, expanding);
                        break;

                    case TouchPhase.Moved:
                        expand(hit, expanding);
                        break;

                    case TouchPhase.Stationary:
                        expand(hit, expanding);
                        break;

                    case TouchPhase.Ended:
                        expanding.expanding = false;
                        break;

                    case TouchPhase.Canceled:
                        expanding.expanding = false;
                        break;
                }
            }
        }
    }
    
    /// <summary>
    /// Expands the object and increments the size
    /// </summary>
    /// <param name="hit">Object to be expanded</param>
    /// <param name="expanding">Is the object expanding</param>
    private void expand(RaycastHit2D hit, Bounce expanding) {
        expanding.expanding = true;
        hit.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
        // get the current value from text
        string currentVal = hit.transform.gameObject.GetComponentInChildren<TextMesh>().text;
        // convert it
        int tmp = Int32.Parse(currentVal);
        tmp++;
        // set the text to the new value
        hit.transform.gameObject.GetComponentInChildren<TextMesh>().text = "" + tmp;

    }

}
