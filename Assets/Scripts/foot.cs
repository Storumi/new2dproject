using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    AudioSource ad;
    HingeJoint2D h2d;
    public bool landed;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
        landed = false;
        h2d = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Stand")){ h2d.useMotor = true; }
        else { h2d.useMotor = false; }
    }
    void OnCollisionEnter2D(Collision2D col) 
    {
        
        if (col.gameObject.name != "Shin Right" &&
            col.gameObject.name != "Shin Left" &&
            col.gameObject.name != "Thigh Right" &&
            col.gameObject.name != "Thigh Left" &&
            col.gameObject.name != "Base" &&
            col.gameObject.name != "Head" &&
            col.gameObject.name != "Bicep Right" && 
            col.gameObject.name != "Bicep Left" &&
            col.gameObject.name != "Forearm Right" &&
            col.gameObject.name != "Forearm Left")
            { landed = true; ad.Play(0);  }
    }
}
