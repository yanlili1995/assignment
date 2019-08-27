using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    
    private bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
           {
            paused = !paused;
        }
        if (paused) {
            Time.timeScale = 0;
        }
        else {
            Time.timeScale = 1;
        }
    }
}
