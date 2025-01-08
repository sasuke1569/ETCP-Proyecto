 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesController : MonoBehaviour
{
    public float damageForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        PlayerHealthController hController = collision.gameObject.GetComponent<PlayerHealthController>();
        hController.Damage();
        
        Rigidbody2D cRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
        cRigidbody.AddForce(Vector2.up * damageForce, ForceMode2D.Impulse);
    }
}