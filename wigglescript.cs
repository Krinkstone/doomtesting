using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wigglescript : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            animator.SetTrigger("HoldW");
        }
    }
}