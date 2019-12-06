using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Ends the game if another circle collide when 
/// this or the other circle is expanding
/// </summary>
/// 
/// Name: Chamod Welhenge (CW)
/// 
/// 2019-10-25 Initial (CW)
/// 
public class CircleCollision : MonoBehaviour

{
    /// <summary>
    /// If this collide with something
    /// </summary>
    /// <param name="collision">Collision with another collider</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If collision with a circle
        if (collision.collider.tag == "Circle")
        {
            
            Bounce current = GetComponent<Bounce>();
            Bounce other = collision.collider.GetComponent<Bounce>();
            // Check if one is expanding
            if (current.expanding || other.expanding)
            {
                GameManager.instance.DeathMenu();
            }
        }
    }

}
