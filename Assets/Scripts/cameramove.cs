using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.Lerp(transform.position, target.transform.position, Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -5);
    }
}
