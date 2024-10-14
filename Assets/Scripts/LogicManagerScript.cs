using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public Text gameOver;

    public Button restart;

    // public PipeMoveScript playerSpeed;
    public BirdScript playerDead;

    void Start(){
        playerDead = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        //Disable Game over and restart at the start of game
        gameOver.gameObject.SetActive(false);
        restart.gameObject.SetActive(false); 

    }

    void Update(){
        playerDead = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>(); 
        EndGame(playerDead.canJump);

    }

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        //using addScore and scoreToAdd allows us to use this
        //function with more variety eg. get 1 point or 5 points
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    //Game will end if the player can not jump. Meaning they have hit something.
    public void EndGame(bool playerAlive){

        //If player is not alive set Game over and restart button on 
        if(!playerAlive){
            gameOver.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
    }

    
    public void RestartGame(){
        SceneManager.LoadScene("Game");
    }


 

    
}
