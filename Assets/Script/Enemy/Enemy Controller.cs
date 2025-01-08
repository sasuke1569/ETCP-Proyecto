using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public Transform[] waypoints;
    public Rigid body2D cRigidbody;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = waypoints[0].position - transform.position;
        cRigidbody.velocity = new Vector2(dir.x * speed, cRigidbody.velocity.y);
    }
}
