using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpSpeed; 
    public bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }

       
    }
    
    //Stop moving when hits obstacle
    public void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Obstacle")){
            canJump = false;
            Debug.Log(other.gameObject.tag + "Can player jump:" + canJump);
        }

        
    }
}
