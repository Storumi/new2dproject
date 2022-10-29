using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    AudioSource ad;
    SpriteRenderer sr;
    List<GameObject> currentCollisions = new List<GameObject>();
    public bool landed;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
        landed = false;
    }
    // Update is called once per frame
    void Update()
    {
        foreach (GameObject gob in currentCollisions)
        {
            if (
                   gob.name != "Shin Right" &&
                   gob.name != "Shin Left" &&
                   gob.name != "Thigh Right" &&
                   gob.name != "Thigh Left" &&
                   gob.name != "Base" &&
                   gob.name != "Head" &&
                   gob.name != "Bicep Right" &&
                   gob.name != "Bicep Left" &&
                   gob.name != "Forearm Right" &&
                   gob.name != "Forearm Left" &&
                   gob.name != "Visor" &&
                   gob.name != "Backpack")

            { landed = true; }
            else { landed = false; }

        }

        if (landed) { sr.color = Color.yellow; }
        else { sr.color = Color.white; }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        currentCollisions.Add(col.gameObject);

        print(col.gameObject.name);
        if (col.gameObject.name != "Shin Right" &&
           col.gameObject.name != "Shin Left" &&
           col.gameObject.name != "Thigh Right" &&
           col.gameObject.name != "Thigh Left" &&
           col.gameObject.name != "Base" &&
           col.gameObject.name != "Head" &&
           col.gameObject.name != "Bicep Right" &&
           col.gameObject.name != "Bicep Left" &&
           col.gameObject.name != "Forearm Right" &&
           col.gameObject.name != "Forearm Left" &&
           col.gameObject.name != "Visor" &&
           col.gameObject.name != "Backpack")
        {ad.Play(0);}

    }
    void OnCollisionStay2D(Collision2D col)
    {

    }
    void OnCollisionExit2D(Collision2D col)
    {    
        currentCollisions.Remove(col.gameObject);
    }
}


