using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public int maxLives = 5;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        if (lives > 0)
            lives = lives - 1; 
    PlayerController hCtr = gameObject.GetComponent<PlayerController>();
    hCtr.cAnimator.SetBool("Hurt", true); 
    }

    public void Regenerate()
    {
        if (lives < 5)
            lives = lives + 1; 
    }
}
