using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    public Text timerText;
    private float startTime;
    private bool endTrigger;

    // Use this for initialization
    void Start()
    {
    endTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (endTrigger == false)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                endTrigger = true;
            }

        }
        if (endTrigger == true)
        {
            float t = (Time.time - startTime);
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f0");
            timerText.text = minutes + ":" + seconds;
            //if (Input.GetKeyDown(KeyCode.Return))
            //{
            //    endTrigger = false;
           // }
        }
    }
}