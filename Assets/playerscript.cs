using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    /*
    public float movespeed;
    public float jumplimit;
    public float gravityscale;
    public float gravityfall;
    public float castdist;
    public int score;
    public bool grounded = false;
    public bool jump = false;
    float horizontalmove;
    Rigidbody2D rb2d;
    Animator Anim;
    SpriteRenderer splight;
    groundscript gs;
    
    // Start is called before the first frame update
    void Start()
    {
        //getting components
        rb2d = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        splight = GetComponent<SpriteRenderer>();
    }

    /*
    // Update is called once per frame
    void Update()
    {
        //getting inputs
        horizontalmove = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded) { jump = true; }

        //why the is there no 2D sprite mirroring functionality in the unity animator :(
        if (Anim.GetBool("facingRight")){ splight.flipX = false; } else { splight.flipX = true; }

        

    }

    void FixedUpdate()
    {
        //physics stuff, see function 
        HorizontalMove(horizontalmove);
        groundDetection();


    }

    void OnGui()
    {
        //draw the score 
        GUI.Label(new Rect(10, 10, 100, 20), score.ToString());
    }

    void HorizontalMove(float toMove)
    {
        //physics stuff
        float moveX = toMove * Time.fixedDeltaTime * movespeed;
        rb2d.velocity = new Vector3(moveX, rb2d.velocity.y);

        //passing information to animator
        if (Mathf.Abs(rb2d.velocity.x) > 0) { Anim.SetBool("iswalking",true); } //&& (Input.GetButtonDown("left")  || Input.GetButtonDown("right"))
        else { Anim.SetBool("iswalking", false); }

        if (grounded) { Anim.SetBool("isgrounded", true); } else { Anim.SetBool("isgrounded", false); }

        if(rb2d.velocity.x > 0) { Anim.SetBool("facingRight", true); } 
        if(rb2d.velocity.x < 0){ Anim.SetBool("facingRight", false); }
    }

    void groundDetection()
    {
        //ground detection
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, castdist);
        
        if (hit.collider != null && hit.collider.gameObject.GetComponent<groundscript>() != null) 
        {          
                grounded = true;
                //Debug.Log(hit.transform.name);            
        }
            else { grounded = false; }

        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumplimit, ForceMode2D.Impulse);
            jump = false;
        }

        if (rb2d.velocity.y >= 0) { rb2d.gravityScale = gravityscale; }
            else if (rb2d.velocity.y < 0) { rb2d.gravityScale = gravityfall; }

        //output + visualizer
        Debug.Log(score.ToString());
        //Debug.Log(GetComponent<SpriteRenderer>().size);
        //Debug.DrawRay(transform.position, Vector2.down * castdist);

    }
*/
}
