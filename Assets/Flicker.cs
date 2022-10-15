using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D myLight;
    int flickerInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(flickerInt == 4)
        {
            myLight.intensity = 0.1f * Random.RandomRange(5, 10);
            flickerInt = 0;
        }
        flickerInt++;
        
    }
}
