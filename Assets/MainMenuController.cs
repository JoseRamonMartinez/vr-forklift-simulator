using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {
        SceneManager.LoadScene("level1");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Debug.Log("QUIT!!!");
        Application.Quit();
    }
}
