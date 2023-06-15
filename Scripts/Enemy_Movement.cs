using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 initialPosition;
    private bool movingRight = true;

    public Animator animator;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.Rotate(Vector3.up * 1);
            animator.Play("walk");
            //Debug.Log("IF MOVING RIGHT");
        }
        else
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
            animator.Play("walk");
            //Debug.Log("ELSE MOVING RIGHT");
        }

        if (Vector3.Distance(transform.position, initialPosition) > 10f)
        {
            movingRight = !movingRight;
            animator.Play("idle");
            //Debug.Log("IF CONDITION");
        }
    }
}