using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollision : MonoBehaviour
{
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter( Collision col){
        if(col.gameObject.name=="Present"){
           //Destroy(col.gameObject);
           win.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
