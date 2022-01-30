using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public float waitTime;
    private float timePassed;

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > waitTime)
            gameObject.SetActive(false);        
    }
}
