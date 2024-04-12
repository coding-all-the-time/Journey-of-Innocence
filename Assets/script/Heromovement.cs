using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heromovement : MonoBehaviour
{
    public Rigidbody2D rb_Hero;
    public float speed_move;
    public float horizontal_number;

    // Start is called before the first frame update
    private void Start()
    {
        rb_Hero = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
       updateCheck();

    }
    private void FixedUpdate()
    {
        Move();
    }

    private void updateCheck()
    {
       horizontal_number=Input.GetAxis("Horizontal");

    }
    private void Move()
    {
        rb_Hero.velocity = new Vector2(horizontal_number *speed_move,rb_Hero.velocity.y);

    }
}
