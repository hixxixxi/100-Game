using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    private string connectionString;
    private List<HighScore> highScores = new List<HighScore>();
    public GameObject scorePrefab;
    public Transform scoreParent;
    public Text enterName;
    public GameObject nameDialog;
    public GameObject EnterNameButton;
    //This needs to be possibly set to true sometimes
    public static bool ScoreEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.db";
        //InsertScore("Chamod", 6000);
        ShowScores();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            nameDialog.SetActive(!nameDialog.activeSelf);
        }

    }
    private void InsertScore(string name, int newScore)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = string.Format("INSERT INTO HighScores(Name,Score) VALUES(\"{0}\",\"{1}\")", name, newScore);


                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar();
                dbConnection.Close();

            }
        }
    }
    void GetScores()
    {
        //We need to clear highscores, otherwise duplicates arise
        highScores.Clear();
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                // string sqlQuery = "SELECT * FROM HighScores";
                string sqlQuery = "SELECT * FROM HighScores ORDER BY Score DESC";

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        highScores.Add(new HighScore(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1), reader.GetDateTime(3)));
                        Debug.Log(reader.GetString(1) + " " + reader.GetInt32(2));
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
    }

    private void ShowScores()
    {
        GetScores();
        foreach (GameObject score in GameObject.FindGameObjectsWithTag("Score"))
        {
            Destroy(score);
        }

        for (int i = 0; i < highScores.Count; i++)
        {
            GameObject tmpObject = Instantiate(scorePrefab);
            HighScore tmpScore = highScores[i];

            tmpObject.GetComponent<HighscoreScript>().SetScore(tmpScore.Name, tmpScore.Score.ToString(), "#" + (i + 1).ToString());

            tmpObject.transform.SetParent(scoreParent);

            tmpObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    }
    public void EnterName()
    {
        //Must be an initial. if it is an initial it inserts score
        if (enterName.text.Length != 2)
        {
            ScoreEntered = false;
            return;
        }
        //this would take finalscore
        ScoreEntered = true;
        InsertScore(enterName.text, TotalScoreScript.totalScoreValue);
        EnterNameButton.SetActive(false);
        ShowScores();
    }
}
