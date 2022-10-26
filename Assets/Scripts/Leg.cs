using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    HingeJoint2D h2d;

    // Start is called before the first frame update
    void Start()
    {
        h2d = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Stand")) { h2d.useMotor = true; }
        else { h2d.useMotor = false; }
    }
}
