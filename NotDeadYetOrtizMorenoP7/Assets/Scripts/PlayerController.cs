using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float directionX, directionY, moveSpeed;
    private Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveSpeed = 6f;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxis("Horizontal") * moveSpeed;
        directionY = Input.GetAxis("Vertical") * moveSpeed;

        AnimationControl();
    }

    private void LateUpdate()
    {
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
        }
        else if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-localScale.x, localScale.y, localScale.z);
        }
    }

    private void AnimationControl()
    {
        if (rb.velocity.y == 0 && rb.velocity.x == 0)
        {
            anim.Play("PlayerIdle");
        }

        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            anim.Play("PlayerRun");
        }
    }
}
