using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLogic : MonoBehaviour
{

    int countDownStartValue=5;
    public Text timerUI;

    public GameObject Time5;
    public GameObject Time4;
    public GameObject Time3;
    public GameObject Time2;
    public GameObject Time1;

    public GameObject Time0;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
        
    }

    void countDownTimer(){
        if( countDownStartValue>0){
            
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text=  ""+spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer",  1.0f);
            
        if(countDownStartValue==5){Time5.SetActive(true);}
        if(countDownStartValue==4){Time5.SetActive(false);Time4.SetActive(true);}
        if(countDownStartValue==3){Time4.SetActive(false);Time3.SetActive(true);}
        if(countDownStartValue==2){Time3.SetActive(false);Time2.SetActive(true);}
        if(countDownStartValue==1){Time2.SetActive(false);Time1.SetActive(true);}

        }
        
        else {
            if(countDownStartValue==0){Time1.SetActive(false);Time0.SetActive(true);}
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

