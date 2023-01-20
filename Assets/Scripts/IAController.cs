using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAController : MonoBehaviour
{
    [SerializeField] float walkForce;
    
    Transform PlayerTransform;
    Rigidbody2D myRigidBody2D;

    private void Awake()
    {
        PlayerTransform = GameObject.FindWithTag("Player").transform;
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private Vector3 GetTargetDirection(Transform target)
    {
        return (target.transform.position - transform.position).normalized;
    }

    void Move()
    {
        Vector3 direction = GetTargetDirection(PlayerTransform);  
        var force = new Vector2(direction.x * walkForce, direction.y * walkForce);

        myRigidBody2D.AddForce(force);
    }
}