using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    Rigidbody2D rb2d;
    List<GameObject> currentCollisions = new List<GameObject>();
    SpriteRenderer sr;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        
        rb2d.bodyType = RigidbodyType2D.Dynamic;
        sr.color = Color.white;
        if (Input.GetButton("GrabR")) { checkhand();  }
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
                    gob.name != "Forearm Left")

                 { rb2d.bodyType = RigidbodyType2D.Static; sr.color = Color.red; }
            
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        print("haha penis");
        // Add the GameObject collided with to the list.
        currentCollisions.Add(col.gameObject);

        // Print the entire list to the console.
        foreach (GameObject gObject in currentCollisions)
        {
            print(gObject.name);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {

        // Remove the GameObject collided with from the list.
        currentCollisions.Remove(col.gameObject);

        // Print the entire list to the console.
        foreach (GameObject gObject in currentCollisions)
        {
            print(gObject.name);
        }
    }
}
