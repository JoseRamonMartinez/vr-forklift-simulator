using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    Transform _tr;
    private Vector3 curPos;
	
    void Awake()
    {
        curPos = transform.position;
        _tr = transform;
    }
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.R))
        {
            // _tr.rotation = new Quaternion(0,90,0,0);
            // transform.position = curPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
