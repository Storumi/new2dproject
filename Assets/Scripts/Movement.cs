using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Movement : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public GameObject title;
    public GameObject flag;
    public foot footl;
    public foot footr;
    public RightHand handr;
    public LeftHand handl;
    float Xin;
    float Yin;
    Vector2 hops;
    Vector2 slides;
    Vector3 turns;
    Rigidbody2D rb2d;
    AudioSource ad;
    TextMeshPro tmp;
    bool started;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ad = GetComponent<AudioSource>();
        tmp = title.GetComponent<TextMeshPro>();
        hops.x = 0;
        hops.y = jumpheight;
        slides.y = 0;

        started = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        Xin = movespeed * Input.GetAxis("Horizontal");
        Yin = movespeed * Input.GetAxis("Vertical");

        slides.x = Xin;
        turns.y = Yin;


        if (Input.GetButtonDown("Jump"))
        {

            if (!started) { startfunction(); }
            if (footl.landed || footr.landed)
            { rb2d.AddForce(hops, ForceMode2D.Impulse); }
        }
        rb2d.AddForce(slides*Time.deltaTime*1000, ForceMode2D.Force);
        rb2d.AddTorque(-Yin * Time.deltaTime*1000, ForceMode2D.Force);

        if (handl.winner || handr.winner) { victory();}
    }
    void fixedUpdate()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col) 
    {
        
       // ad.Play(0);
    }
    void startfunction()
    {
        started = true;
        title.SetActive(false);
        rb2d.bodyType = RigidbodyType2D.Dynamic;
    }
    void victory()
    {
        title.SetActive(true);
        tmp.text = "You Win";
    }
}
