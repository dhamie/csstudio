using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int enemylife = 1;


    void OnTriggerEnter2D(){
        Debug.Log("Trigger");
        enemylife--;
    }

    void Update(){
        if (enemylife <= 0)
        {
            Destroy(gameObject);
        }
    }


}
