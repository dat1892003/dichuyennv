using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float movespeed = 5f;
    public float x,y;
    public Animator aim;
    public bool swap=true;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxisRaw("Horizontal");
        y= Input.GetAxisRaw("Vertical");
        //rb.velocity = new Vector2(x*movespeed,rb.velocity.y);
        //rb.velocity = new Vector2(rb.velocity.x, y*movespeed);
        rb.MovePosition(rb.position + new Vector2(x,y) * movespeed * Time.fixedDeltaTime);
        aim.SetFloat("Horizontal",x);
        aim.SetFloat("Vertical",y);
        aim.SetFloat("speed", 1);
        if (x == 0 && y == 0)
        {
            aim.SetFloat("speed", -1);
        }
    }
}
