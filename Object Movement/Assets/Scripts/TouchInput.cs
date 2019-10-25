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
                print("Touch Detect");
                switch (t.phase)
                {
                    case TouchPhase.Began:
                        print("Touch Began");
                        hit.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
                        expanding.expanding = true;
                        break;
                    case TouchPhase.Moved:
                        print("Touch Moved");
                        hit.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
                        expanding.expanding = true;
                        break;
                    case TouchPhase.Stationary:
                        print("Touch Stationary");
                        hit.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
                        expanding.expanding = true;
                        break;
                    case TouchPhase.Ended:
                        print("Touch Ended");
                        expanding.expanding = false;
                        break;
                    case TouchPhase.Canceled:
                        print("Too many touches.");
                        expanding.expanding = false;
                        break;
                }
            }
            
            
        }
    }

}
