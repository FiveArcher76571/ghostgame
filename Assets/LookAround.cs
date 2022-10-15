using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{

    public PolygonCollider2D col;
    public int counter;
    public Quaternion from;
    public Quaternion to;
    private float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        //timeCount = 0.0f;
        col = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter == 600)
        {
            to = Quaternion.Euler(0, 0, 90);
            from = Quaternion.Euler(0, 0, 180);
            counter = 0;
            timeCount = 0;
        }

        else if(counter == 300)
        {
            to = Quaternion.Euler(0, 0, 180);
            from = Quaternion.Euler(0, 0, 90);
            timeCount = 0;
        }

        transform.rotation = Quaternion.Slerp(from, to, timeCount);
        timeCount = timeCount + Time.deltaTime;
        counter++;
    }
}
