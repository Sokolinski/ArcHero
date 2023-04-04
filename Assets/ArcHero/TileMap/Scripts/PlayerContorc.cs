using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorc : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Joystick joystick;
    
    private float dirY, dirX;
    private Rigidbody2D rb;
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        dirX = joystick.Horizontal * speed ;
        dirY = joystick.Vertical * speed ;
    }

    void FixedUpdate()
    {
         rb.velocity = new Vector2(dirX, dirY); 
    }
}
