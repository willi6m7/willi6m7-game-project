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
        if (movementInput.x < 0)
        {
            if (movementInput.y > 0)
            {
                direction = new Vector3(-0.5f, 0.5f);
            }
            else if (movementInput.y < 0)
            {
                direction = new Vector3(-0.5f, 0.5f);
            }
            else
            {
                direction = new Vector3(-1, 0, 0);
            }
            transform.position += direction;
        }
        else if (movementInput.x > 0)
        {
            if(movementInput.y > 0)
            {
                direction = new Vector3(0.5f, 0.5f);
            }
            else if (movementInput.y < 0)
            {
                direction = new Vector3(0.5f, -0.5f);
            }
            else
            {
                direction = new Vector3(1, 0, 0);
            }
            transform.position += direction;
        }
    }

public void OnMove()
    {
        //movementInput = value.Get<Vector2>();
    }

}
