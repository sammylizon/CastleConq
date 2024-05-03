using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    //import/reference another script
    public LogicManagerScript logic;

    // Start is called before the first frame update
    void Start()
    {
        //find first Game onject with tag - Logic and then go through
        //its components and find the 'LogicManagerScript' so we can
        //reference the score
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
          logic.AddScore(1);

        }
    }
}
