using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float speed = 500f;
    bool walk;
    float moveX;
    float moveY;
    public float keys = 0;
    public float gems = 0;
    public float hearts = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = rb.velocity.x;
        moveY = rb.velocity.y;
        if (((moveX < 0.01) && (moveX > -0.01)) || ((moveY < 0.01) && (moveY > -0.01)))
        {
            animator.SetBool("walk", false);
        }
        if (((moveX > 0.01) || (moveX < -0.01)) || ((moveY > 0.01) || (moveY < -0.01)))
        {
           animator.SetBool("walk", true);
        }
    }

    void FixedUpdate()
    {
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        rb.AddForce(force);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "key")
        {
            keys = keys + 1;
        }
        if (other.tag == "gem")
        {
            gems = gems + 1;
        }
        if (other.tag == "heart")
        {
            hearts = hearts + 1;
        }
    }
}
