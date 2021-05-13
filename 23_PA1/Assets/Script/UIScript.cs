using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Text UIScoreText;
    int score = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreIncrement()
    {
        //Increase Score upon killed
        score += 1;
        UIScoreText.text = "Kills: " + score.ToString();

        //When player hit the amount of kill it will change to other scene
        if(score > 50)
        {
           SceneManager.LoadScene("Win");
      }
    }
}
