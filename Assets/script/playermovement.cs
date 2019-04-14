using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 3.5f;
    public float size = 0.5f;
    public float sizetop = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        Vector2 position = transform.position;
        position.y = position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime;
        position.x = position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //screen width
        float screensize = (float)Screen.width / (float)Screen.height;
        float finalsize = Camera.main.orthographicSize * screensize;


        //y boundries
        if (position.y + sizetop > Camera.main.orthographicSize){
            position.y = Camera.main.orthographicSize - sizetop;
        }

        if(position.y - size < -Camera.main.orthographicSize){
            position.y = -Camera.main.orthographicSize + size;
        }

        //x boundries
        if (position.x + size > finalsize){
            position.x = finalsize - size;
        }

        if (position.x - size < -finalsize){
            position.x = -finalsize + size;
        }

        //final upadate
        transform.position = position;

    }
}
