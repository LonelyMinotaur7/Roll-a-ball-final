using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer = 0;

    public TextMeshProUGUI TimerTxt;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        //Debug.Log(Name.NameRaw);

        
        TimerTxt.text = timer.ToString("0.0");
    }
}
