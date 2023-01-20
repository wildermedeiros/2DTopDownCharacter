using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float walkForce = 100f;

    Vector2 axesValues;
    Rigidbody2D myRigidBody2D;

    private void Awake() 
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        Move();    
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        axesValues = context.ReadValue<Vector2>();
    }

    private void Move()
    {
        if (axesValues.sqrMagnitude < 0.01f) { return; }

        var force = new Vector2(axesValues.x * walkForce, axesValues.y * walkForce);

        myRigidBody2D.AddForce(force);
    }
}
