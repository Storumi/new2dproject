using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetswap : MonoBehaviour
{
    public GameObject camera;
    public  bool fired;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {    
            if (col.gameObject.GetComponent<targetswap>()!=null && col.gameObject.GetComponent<targetswap>().fired==false)
            { camera.GetComponent<cameramove>().target = col.gameObject; col.gameObject.GetComponent<targetswap>().fired = true;} 
    }                                                     
                                                                           

}



