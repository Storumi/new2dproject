using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetswap : MonoBehaviour
{
    public GameObject camera;
    bool fired;
    // Start is called before the first frame update
    void Start()
    {
        fired= false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col) { if ((col.gameObject.name == "Domino") && !fired) { camera.GetComponent<cameramove>().target = col.gameObject; fired = true; } }

}



