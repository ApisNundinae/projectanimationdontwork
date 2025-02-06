using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float moveSpeed = 5.0f;

    private Vector2 moveInput;
    private Vector2 lastMoveDirection = Vector2.down; 
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    private void Start()
    {
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.gravityScale = 0;
            rb.freezeRotation = true;
        }

        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        Vector2 moveDirection = new Vector2(moveInput.x, moveInput.y).normalized;

        if (moveDirection.magnitude > 0.01f)
        {
            lastMoveDirection = moveDirection;
        }

        rb.linearVelocity = moveDirection * moveSpeed;
        updateAnimation(moveDirection);
    }

    private void updateAnimation(Vector2 moveDirection)
    {
        bool isMoving = moveDirection.magnitude > 0.01f;
        anim.SetBool("isMove", isMoving);

        if (isMoving)
        {
            anim.SetFloat("moveX", moveDirection.x);
            anim.SetFloat("moveY", moveDirection.y);
        }
        else
        {
            anim.SetFloat("moveX", lastMoveDirection.x);
            anim.SetFloat("moveY", lastMoveDirection.y);
        }

        if (lastMoveDirection.x < 0)
        {
            anim.SetBool("isFacingLeft", true);
        }
        else if (lastMoveDirection.x > 0)
        {
            anim.SetBool("isFacingLeft", false);
        }
    }
}