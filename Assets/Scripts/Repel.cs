using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repel : MonoBehaviour
{
    [SerializeField] float repelForce = 5000f;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Bati");
        
        var direction = other.transform.position - transform.position;
        
        var force = new Vector2(direction.normalized.x * repelForce, direction.normalized.y * repelForce);

        other.gameObject.GetComponent<Rigidbody2D>().AddForce(force);
    }
}
