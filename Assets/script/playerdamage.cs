using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdamage : MonoBehaviour

    // Start is called before the first frame update
{
    public int playerlife = 10;
    int score = 0;
    float timer = 5;


    void OnTriggerEnter2D()
    {
        
        playerlife--;
        //Debug.Log(playerlife);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (playerlife <= 0)
        {
            Destroy(gameObject);
        }

        if(timer <= 0)
        {
            score = score + 1;
            timer = 5;
        }
        Debug.Log(score);

   
    }


}

