using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    Rigidbody2D rb2d;
    List<GameObject> currentCollisions = new List<GameObject>();
    SpriteRenderer sr;
    public bool winner;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        winner = false;
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if (Input.GetButton("GrabR")) { checkhand();  }
        else { rb2d.bodyType = RigidbodyType2D.Dynamic; sr.color = Color.white;}
    }
    void checkhand()
    {

      foreach(GameObject gob in currentCollisions)
        {
             if(
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

                 { rb2d.bodyType = RigidbodyType2D.Static; sr.color = Color.red; }
            
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {       
        currentCollisions.Add(col.gameObject);
        if (col.gameObject.name == "FlagPole") { winner = true; }
    }
    void OnCollisionExit2D(Collision2D col)
    {      
        currentCollisions.Remove(col.gameObject);      
    }
}
