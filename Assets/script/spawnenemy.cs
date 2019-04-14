using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    public GameObject enemyship;
    public float pos = 2.2f;
    public float delay = 1f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 shippos = new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z);
            Instantiate(enemyship, shippos, transform.rotation);
            timer = delay;
        }
    }
}
