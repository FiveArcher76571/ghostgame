using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pathf = Pathfinding;

public class DetectKid : MonoBehaviour
{

    public Collider2D child;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == child)
        {
            GetComponent<pathf.AIPath>().enabled = true;
        }
    }
}
