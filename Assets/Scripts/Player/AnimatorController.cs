using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    private CharacterMovement characterMovement;
    private Rigidbody rigidbody; 

    public void Start()
    {
        animator = GetComponent<Animator>();
        characterMovement = GetComponent<CharacterMovement>();
        rigidbody = GetComponent<Rigidbody>();
    }
    public void LateUpdate()
    {
       UpdateAnimator();
    }

    // TODO Fill this in with your animator calls
    void UpdateAnimator()
    {
        animator.SetFloat("CharacterSpeed", rigidbody.velocity.magnitude);
        animator.SetBool("IsGrounded", characterMovement.IsGrounded);
        if(characterMovement.DoubleJump)
        {
            animator.SetTrigger("DoubleJump");
        
        }

    }
}
