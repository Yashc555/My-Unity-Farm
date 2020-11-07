using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float moveSpeed = 5f; 
   
    public Rigidbody2D Darwin;

    public Vector2 movement;
    

    private void Start()
    {
        Darwin = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
         movement.x = Input.GetAxisRaw("HorizontalWithAD");
         movement.y = Input.GetAxisRaw("VerticalWithSW");     
    }
    void FixedUpdate()
    {
            Darwin.MovePosition(Darwin.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
}
