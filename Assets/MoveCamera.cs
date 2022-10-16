using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    Vector3 offset = new Vector3(0, 0, -4);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.transform.position + offset;
    }

    IEnumerator ZoomOnObject(Transform focus)
    {
        Transform old = target;
        target = focus;

        yield return new WaitForSeconds(1);

        target = old;
    }
}
