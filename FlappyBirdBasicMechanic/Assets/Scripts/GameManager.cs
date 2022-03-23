using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text txtScore ;
    public int score = 0;

    void Start()
    {
        score = 0;
        txtScore.text = score.ToString();
        Debug.Log("bas");
    }

    public void ScoreUpdate()
    {
        score += 1;
        txtScore.text = score.ToString();
        Debug.Log(score.ToString());
    }

    public void Restart()
    {
        Debug.Log("r button");
        SceneManager.LoadScene(0);
    }

}
