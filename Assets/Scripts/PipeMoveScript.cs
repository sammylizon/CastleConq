using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float speed;
    public float deadZone = -45f;
    public Transform spawner;

    //try increase speed by referencing logic score
    public LogicManagerScript logicman;

    // Start is called before the first frame update
    void Start()
    {
        logicman = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();  
    }

    // Update is called once per frame
    void Update()
    {
        MoveSpeed(5f);
        IncreaseSpeed();
        if (spawner.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

    public void MoveSpeed(float moveSpeed)
    {
        spawner.position += Vector3.left * moveSpeed * Time.deltaTime;
        speed = moveSpeed;

    }

    //create an if function checking for score and increase speed
    //first state machine lol

    //update : use if...else as this produces burst until next point
    //instead use range score > 10 then speed = n;
    //also think about how to add speed to UI, so far tried and failed,
    //its adding every frame and i need better refernce as pipe is not in until start
    public void IncreaseSpeed()
    {
        
        switch (logicman.playerScore)
        {
            case 5:
                MoveSpeed(10);
                print("Speed: 10");
                break;
            case 10:
                MoveSpeed(10f);
                print("Speed: 15");

                break;
            case 15:
                MoveSpeed(15f);
                print("Speed: 20");

                break;
            case 20:
                MoveSpeed(20f);
                print("Speed: 25");
                break;
        }
    }
}
