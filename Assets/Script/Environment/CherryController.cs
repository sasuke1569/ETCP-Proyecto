using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        PlayerHealthController hController = collision.gameObject.GetComponent<PlayerHealthController>();
        hController.Regenerate();

        Destroy(this.gameObject);
    }
}
