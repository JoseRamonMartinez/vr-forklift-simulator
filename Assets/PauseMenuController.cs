using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{

    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseMenu(){
        pause.SetActive(false); 
    }
    public void MainMenu(){
         SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public  void RestartLevel(){SceneManager.LoadScene("level1", LoadSceneMode.Single);}
}
        
