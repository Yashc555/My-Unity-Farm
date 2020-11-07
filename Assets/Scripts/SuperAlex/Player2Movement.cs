using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D SuperAlex;

    public Vector2 movement;
    

    private void Start()
    {
        SuperAlex = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("HorizontalWithArrow");
        movement.y = Input.GetAxisRaw("VerticalWithArrow");
    }
    void FixedUpdate()
    {
        SuperAlex.MovePosition(SuperAlex.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
