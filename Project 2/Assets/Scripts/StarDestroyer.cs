using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDestroyer : MonoBehaviour
{
    public Player player;
    public AudioSource miss;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Causes the player to lose one life, as well as playing a sound effect and destroying the colliding object.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.LoseLife();
        miss.Play();
        Destroy(collision.gameObject);
    }
}
