using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the ball velocity
/// </summary>
/// 
/// Field           Description
/// ball            The ball object to move
/// ballSpeed       Speed of the ball movement
/// expanding       Is the ball expanding
/// 
/// Author: Chamod Welhenge
/// 
public class Bounce : MonoBehaviour
{
    private Rigidbody2D ball;
    private float ballSpeed = 4f;
    internal bool expanding = false;

    /// <summary>
    /// Dry yjr ball velocity, so it bouncces
    /// </summary>
    void Start()
    {
        // find the rigid body component
        ball = GetComponent<Rigidbody2D>();
        // Set the balls velocity
        ball.velocity = new Vector2(ballSpeed, ballSpeed);
    }
}
