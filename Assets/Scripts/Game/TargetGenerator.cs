using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generates targets for the game
/// </summary>
/// 
/// Field           Description
/// myPrefab        Prefab of the object to be instantiated 
/// limit           Limit of objects to be instantiated
/// upForce         For random object force
/// sideForce       For random object force
/// circlesList     List to hold all the circles
/// 
/// Source: https://www.youtube.com/watch?v=tdSmKaJvCoA (For calculating random forces)
/// 
/// Author: Chamod Welhenge
/// 
public class TargetGenerator : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject myPrefab;
    public int limit = 10;
    public float upForce = 1f;
    public float sideForce = .1f;
    public List<GameObject> circlesList;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < limit; i++)
        {
            GameObject tmp;
            // Instantiate at position (0, 0, 0) and zero rotation.
            tmp = Instantiate(myPrefab, new Vector2(0, 0), Quaternion.identity);
            TextMesh text = tmp.GetComponentInChildren<TextMesh>();
            text.text = ""+ 0;
            circlesList.Add(tmp);

            // Random force vector
            float Xforce = Random.Range(-sideForce, sideForce);
            float yForce = Random.Range(upForce / 2f, upForce);
            float zForce = Random.Range(-sideForce, sideForce);

            Vector3 Force = new Vector3(Xforce, yForce, zForce);

            // Set rigidBody velocity to new random Force;
            tmp.GetComponent<Rigidbody2D>().velocity = Force;

        }

    }
}
