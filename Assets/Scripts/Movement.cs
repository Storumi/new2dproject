using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public GameObject footl1;
    public GameObject footr1;
    public foot footl;
    public foot footr;
    
    float Xin;
    float Yin;
    Vector2 hops;
    Vector2 slides;
    Vector3 turns;
    private Rigidbody2D rb2d;
    AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        hops.x = 0;
        hops.y = jumpheight;
        slides.y = 0;
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Xin = movespeed * Input.GetAxis("Horizontal");
        Yin = movespeed * Input.GetAxis("Vertical");
        slides.x = Xin;
        turns.y = Yin;
        if (Input.GetButtonDown("Jump") && ( footl.landed || footr.landed)) { footl.landed = false ; footr.landed = false ; rb2d.AddForce(hops, ForceMode2D.Impulse) ; }
        rb2d.AddForce(slides, ForceMode2D.Force);
        rb2d.AddTorque(-2*Yin, ForceMode2D.Force);

    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
       // ad.Play(0);
    }
}
