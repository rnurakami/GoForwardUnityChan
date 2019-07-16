using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{

    Animator animator;

    private float groundLevel = -3.0f;

    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.animator.SetFloat("Horizontal", 1);

        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

    }
}
