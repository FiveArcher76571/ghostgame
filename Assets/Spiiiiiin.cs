using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spiiiiiin : MonoBehaviour
{
    Vector3 spinVec = new Vector3(0, 0, 1);
    public Collider2D playerCol;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(spinVec);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col == playerCol)
        {
            SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
        }
    }
}