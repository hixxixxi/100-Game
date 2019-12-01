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
    ///Sean- Changed this to static, if there are conflicts/problems look here-Sean
    public static int limit = 1;
    public static List<GameObject> circlesList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

        SpawnBalls();
    }

    public static void IncreaseDifficulty()
    {
        LevelScript.levelValue++;
        for (int i = 0; i < circlesList.Count; i++)  {Destroy(circlesList[i]);}
        circlesList.Clear();
        limit++;
    }

    public void SpawnBalls()
    { //Score gets reset to 0 whenever the user starts the level.
        //If there is a bug when going to another level, check here to see if setting the scoreValue is conflciting.
        ScoreScript.scoreValue = 0;
        for (int i = 0; i < limit; i++)
        {
            GameObject tmp;

            // https://www.youtube.com/watch?v=t2Cs71rDlUg for the method
            float spawnPosX = Random.Range(-8.5f, 9.5f);
            float spawnPosY = Random.Range(-4.5f, 5.5f);
            Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY);


            tmp = Instantiate(myPrefab, spawnPos, Quaternion.identity) as GameObject;


            TextMesh text = tmp.GetComponentInChildren<TextMesh>();
            text.text = "" + 0;
            circlesList.Add(tmp);
        }
    }
}