using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.y = position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime;
        position.x = position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = position;
        
    }
}
