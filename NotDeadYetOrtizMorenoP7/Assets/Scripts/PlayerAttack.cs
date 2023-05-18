using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Animator anim;

    [SerializeField] private float attackSpeed;

    [SerializeField] private float damage;

    float meleeCountdown;

    private void Update()
    {
        if(meleeCountdown <= 0f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Attack");
                meleeCountdown = attackSpeed;
            }
        }
        else
        {
            meleeCountdown -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("Enemy hit!");
        }
    }
}
