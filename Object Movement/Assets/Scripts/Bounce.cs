using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Bounces the ball around the screen
/// </summary>
/// 
/// Field           Description
/// ball            The ball object to move
/// 
/// Author: Chamod Welhenge
/// 
public class Bounce : MonoBehaviour
{
    private Rigidbody2D ball;
    public float ballSpeed = 4f;
    internal bool expanding = false;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // find the rigid body component
        ball = GetComponent<Rigidbody2D>();
        // Set the balls velocity
        ball.velocity = new Vector2(ballSpeed, ballSpeed);
    }
}
