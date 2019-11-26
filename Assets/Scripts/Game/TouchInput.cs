using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
      ///checks if game is paused, if so then pause everything.
        if (PauseMenu.GameIsPaused) {
            return;

        }
        //We check if win condition has been made
        checkWinCondition();
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
        // get the current value from text
        string currentVal = hit.transform.gameObject.GetComponentInChildren<TextMesh>().text;
        // convert it
        int tmp = Int32.Parse(currentVal);
        if (tmp >= 100) {
            return;
        }
        expanding.expanding = true;
        hit.transform.localScale += new Vector3(scaleFactor/4, scaleFactor/4, scaleFactor/4);
        tmp++;
        // set the text to the new value
        hit.transform.gameObject.GetComponentInChildren<TextMesh>().text = "" + tmp;
        //Here we update the score and total score;
        ScoreScript.scoreValue++;
        TotalScoreScript.totalScoreValue++;
    }
    /// <summary>
    /// -Sean, checks the win condtion by multiplying 100 by the targetgenerator limit.
    /// </summary>
    public void checkWinCondition() {
        if (ScoreScript.scoreValue == 100) {
            ///The below lines are some debug lines/thoughts
            /////This debug line is just for testing.
            Debug.Log("YAY YOU WON");
            GameManager.instance.NextLevel();
            ///Here you could stop the game, then present the won the level menu,
            ///Once the user presses the next level button, you would remove all the circles from the circle list (make a static void method in targetgenerator to remove all the lists)
            ///Then you would update the level count UI (has not been created yet)., just ++ the level count by 1
            /// Then you despawn the won the level menu, spawn in the circles, keep in mind that since it is a new level we either increase the amount of balls/increase the speed factor.
            //ScoreScript.scoreValue = 0;
            //LevelScript.levelValue++;

        }
    }
}
