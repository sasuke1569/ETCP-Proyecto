using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransforms : MonoBehaviour
{

    void Awake()
    {
    
        Debug.Log("Awake" + name);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start" + name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("Update");
        transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime;
        transform.position += new Vector3(0, 0.001f, 0) * Time.deltaTime;
        transform.localScale += new Vector3(0.001f, 0.001f, 0.001f) * Time.deltaTime;
    }

}
