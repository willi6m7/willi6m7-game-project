using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    private Vector2 movementInput;
    private Vector3 direction;

    public Animator animator;

    bool hasMoved;
    bool beenBlocked = false;

    private void Start()
    {
        
    }

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

    //Method for movement controls on a point-topped hexagonal map
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

    //Method handling collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        beenBlocked = true;
        animator.SetBool("beenRepelled", beenBlocked);
        transform.position -= direction;
        StartCoroutine("StopCollisionAnimation");
    }

    //Method controlling the cooldown of a collision animation
    public void OnCollisionCooldown()
    {
        beenBlocked = false;
        animator.SetBool("beenRepelled", beenBlocked);
    }

    //Method handling the wait time of playing the collision animation. Calls OnCollisionCooldown().
    IEnumerator StopCollisionAnimation()
    {
        yield return new WaitForSeconds(2);
        OnCollisionCooldown();
    }

}
