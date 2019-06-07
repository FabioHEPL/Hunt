using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : ObjectPhysics
{
    private PlayerManager manager;


    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    [SerializeField]
    private bool jumping = false;

    [SerializeField]
    public float duration = 2.5f;

    private SpriteRenderer spriteRenderer;
   // private Animator animator;

    // Use this for initialization
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        manager = FindObjectOfType<PlayerManager>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        manager.JumpRequest += OnPlayerManagerJumpRequest;
    }

    private void OnDisable()
    {
        manager.JumpRequest -= OnPlayerManagerJumpRequest;
    }

    private void OnPlayerManagerJumpRequest(object sender, JumpArgs e)
    {
        if (!jumping)
        {
            StartCoroutine(Jump());
        }
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        //bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        //if (flipSprite)
        //{
        //    spriteRenderer.flipX = !spriteRenderer.flipX;
        //}

        //animator.SetBool("grounded", grounded);
        //animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }


    public IEnumerator Jump()
    {
        jumping = true;

        float currentTime = 0;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            velocity.y = jumpTakeOffSpeed;
            yield return null;
        }

        jumping = false;
    }
}
