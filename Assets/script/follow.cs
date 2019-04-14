using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    float rspeed = 180f;
    public Transform player;
    public GameObject go;

    // Update is called once per frame
    void Update()

          
    {
        go = GameObject.FindWithTag("Player");
        player = go.transform;
        /*if (player == null)
        {            

            if (player != null)
            {
                
            }
        }*/



        if (player == null)
        {
            return;
        }

        Vector3 direct = player.position - transform.position;
        direct.Normalize();

        float angle = Mathf.Atan2(direct.y, direct.x) * Mathf.Rad2Deg - 90;

        Quaternion actualr = Quaternion.Euler(0, 0, angle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, actualr, rspeed * Time.deltaTime); 
    }
}
