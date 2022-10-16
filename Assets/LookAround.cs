using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{

    public PolygonCollider2D col;
    public GameObject player;
    public CapsuleCollider2D playerCollider;
    public int counter;
    public Quaternion from;
    public Quaternion to;
    private float timeCount;
    public float timeStopCounter;
    public bool beingTriggered;
    public AudioSource alert;
    public UnityEngine.Rendering.Universal.Light2D light;
    //public Component mainCamController;

    // Start is called before the first frame update
    void Start()
    {
        //timeCount = 0.0f;
        timeStopCounter = 0.0f;
        col = GetComponent<PolygonCollider2D>();
        playerCollider = player.GetComponent<CapsuleCollider2D>();
        //alert = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    private void Update()
    {
        if (timeStopCounter > 0)
        {
            timeStopCounter += Time.unscaledDeltaTime;
            if (timeStopCounter > 1.5)
            {
                Time.timeScale = 1;
                timeStopCounter = 0;
                //GetComponent<Collider2D>().enabled = true;
                light.enabled = false;
                enabled = false;
            }

        }
    }
    void FixedUpdate()
    {
        if (counter == 600)
        {
            to = Quaternion.Euler(0, 0, 90);
            from = Quaternion.Euler(0, 0, 180);
            counter = 0;
            timeCount = 0;
        }

        else if (counter == 300)
        {
            to = Quaternion.Euler(0, 0, 180);
            from = Quaternion.Euler(0, 0, 90);
            timeCount = 0;
        }

        transform.rotation = Quaternion.Slerp(from, to, timeCount);
        timeCount = timeCount + Time.deltaTime;
        counter++;



        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        beingTriggered = true;
        if (col == playerCollider)
        {
            beingTriggered = true;
            alert.Play();
            
            Time.timeScale = 0.0f;
            timeStopCounter = 1;
            GetComponent<Collider2D>().enabled = false;
            
        }

        
    }
}