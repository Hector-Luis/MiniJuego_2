using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 2f;
    public float max_speed = 5f;
    public bool toca_suelo;
    private Rigidbody2D rb2d;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velocidad", Mathf.Abs(rb2d.velocity.x));
        animator.SetBool("toca_suelo", toca_suelo);
    }

    void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * speed * h);
        /*if (rb2d.velocity.x > max_speed) {
            rb2d.velocity = new Vector2(max_speed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -max_speed)
        {
            rb2d.velocity = new Vector2(-max_speed, rb2d.velocity.y);
        }*/

        float limit_speed = Mathf.Clamp(rb2d.velocity.x, -max_speed, max_speed);
        rb2d.velocity = new Vector2(limit_speed, rb2d.velocity.y);

        Debug.Log(toca_suelo);
    }
}
