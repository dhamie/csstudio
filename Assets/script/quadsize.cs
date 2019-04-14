using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadsize : MonoBehaviour
{
    Collider m_Collider;
    public float size = 0.5f;
    public float sizetop = 0.7f;

    void Start()
    {
        
    }

    void Update()
    {

        m_Collider = GetComponent<Collider>();
       Vector3 m_Size = m_Collider.bounds.size;
        


        //screen width
        float screensize = (float)Screen.width / (float)Screen.height;
        float finalsize = Camera.main.orthographicSize * screensize;


        //y boundries
        if (m_Size.y + sizetop > Camera.main.orthographicSize)
        {
            m_Size.y = Camera.main.orthographicSize - sizetop;
        }

        if (m_Size.y - size < -Camera.main.orthographicSize)
        {
            m_Size.y = -Camera.main.orthographicSize + size;
        }

        //x boundries
        if (m_Size.x + size > finalsize)
        {
            m_Size.x = finalsize - size;
        }

        if (m_Size.x - size < -finalsize)
        {
            m_Size.x = -finalsize + size;
        }

        Debug.Log(m_Size);

        transform.localScale += new Vector3(m_Size.x, m_Size.y, m_Size.z);
    }
}
