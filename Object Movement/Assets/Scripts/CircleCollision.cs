using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleCollision : MonoBehaviour

{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Circle")
        {
            Bounce current = GetComponent<Bounce>();
            Bounce other = collision.collider.GetComponent<Bounce>();
            if (current.expanding || other.expanding)
            {
                SceneManager.LoadScene("EndScene");
            }
        }
    }

}
