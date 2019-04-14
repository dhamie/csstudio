using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public float firedelay = 10f;
    public GameObject bulletPrefab;
    float cooldowntimer = 0;


    // Update is called once per frame
    void Update()
    {

        cooldowntimer -= Time.deltaTime;
        if (cooldowntimer <= 0)
        {
            Debug.Log("hey");
            Vector3 offset = new Vector3(0, 0.6f, 0);
            Vector3 newoffset = transform.rotation * offset;
            GameObject bulleto= (GameObject)Instantiate(bulletPrefab, transform.position + newoffset, transform.rotation);
            cooldowntimer = firedelay;
            bulleto.layer = gameObject.layer;


        }
    }


}
