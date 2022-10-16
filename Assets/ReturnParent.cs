using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pathf = Pathfinding;

public class ReturnParent : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D parentCol;
    public GameObject parent;
    public Transform retreatPoint;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Run parents run!");
        if (col == parentCol)
        {
            
            parent.GetComponent<pathf.AIDestinationSetter>().target = retreatPoint;
        }
    }
}