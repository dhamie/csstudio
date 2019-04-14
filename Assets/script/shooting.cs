using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour{
    public float firedelay = 10f;
    public bool checkfire;
    public GameObject bulletPrefab;
    float cooldowntimer = 0;
    int shottimer = 0;

    void start()
    {
        checkfire = false;
    }

    // Update is called once per frame
    void Update(){

        cooldowntimer -= Time.deltaTime;
        if (Input.GetButton("Fire3") && checkfire == false )
        {
            checkfire = true;

            
        }
        else if (Input.GetButton("Fire3") && checkfire == true)
        {
            checkfire = false;
        }
        //Debug.Log(checkfire);
        fire();

    }

    void fire()
    {
        if(shottimer < 10)
        {
            shottimer++;
        }else

        if (checkfire == true && cooldowntimer <= 0 && shottimer == 10)
        {
            //Debug.Log("hey");
            Vector3 offset = new Vector3(0, 0.6f, 0);
            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            cooldowntimer = firedelay;
            shottimer = 0;
        }
    }

     
}
