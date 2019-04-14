using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int bulletlife = 1;


    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger");
        bulletlife--;
    }

    void Update()
    {
        if (bulletlife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
