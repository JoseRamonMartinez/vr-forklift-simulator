using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerGameOverLogic : MonoBehaviour
{

    int countDownStartValue=120;
    public GameObject lose;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
        
    }

    void countDownTimer(){
        if( countDownStartValue>0){
            
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text= spanTime.Minutes+ " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer",  1.0f);
        }
        else {
            timerUI.text="Time Over!";
            lose.SetActive(true);
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

