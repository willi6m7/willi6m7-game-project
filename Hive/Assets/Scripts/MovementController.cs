using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    private Vector2 movementInput;
    private Vector3 direction;

    bool hasMoved;

    // Update is called once per frame
    void Update()
    {
        if (movementInput.x == 0)
        {
            hasMoved = false;
        }
        else if (movementInput.x != 0 && !hasMoved)
        {
            hasMoved = true;

            GetMovementDirection();
        }

        movementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public void GetMovementDirection()
    {
        if (movementInput.x < 0) //LEFT
        {
            if (movementInput.y > 0) //Left Up
            {
                direction = new Vector3(-0.5f, 0.5f);
            }
            else if (movementInput.y < 0) //Left Down
            {
                direction = new Vector3(-0.5f, -0.5f);
            }
            else //Move Left
            {
                direction = new Vector3(-1, 0, 0);
            }
            transform.position += direction;
        }
        else if (movementInput.x > 0) //RIGHT
        {
            if(movementInput.y > 0) //Right up
            {
                direction = new Vector3(0.5f, 0.5f);
            }
            else if (movementInput.y < 0) //Right down
            {
                direction = new Vector3(0.5f, -0.5f);
            }
            else //Move Right
            {
                direction = new Vector3(1, 0, 0);
            }
            transform.position += direction;
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position -= direction;
    }
}
