using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmove : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    [SerializeField]
    bool onGround = false;
    bool isDuck = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal motion when pressing left/right
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
        
        //jumping action
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (onGround == true)
            {
                rb.velocity = new Vector2(rb.velocity.x, 14f);
                onGround = false;
            }
        }

        //ducking action
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (onGround == true)
            {
                isDuck = true;
                bc.size = new Vector2(bc.size.x, 1f);
            }
            if (!onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, -5f);
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            isDuck = false;
            bc.size = new Vector2(bc.size.x, 2.05f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            if (onGround == false)
            {
                onGround = true;
            }
        }
    }
}
