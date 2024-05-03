using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public PipeMoveScript playerSpeed;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        //using addScore and scoreToAdd allows us to use this
        //function with more variety eg. get 1 point or 5 points
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

 

    
}
