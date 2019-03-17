using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMovement : MonoBehaviour
{
    [Header("Speed")]
    [Tooltip("The speed at which the spawner will move")]
    [Range(0, 5)]
    public float speed;
    [Header("Direction Change Chance")]
    [Tooltip("The chance that the spawner will switch directions each frame")]
    [Range(0, 0.1f)]
    public float directionChance;

    private bool direction = false;
    private float edgeValue = 8f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -edgeValue)
        {
            direction = true;
        }
        else if (transform.position.x > edgeValue)
        {
            direction = false;
        }
        else if (Random.value < directionChance)
        {
            direction = !direction;
        }

        MoveSpawner(direction);
 
    }

    void MoveSpawner(bool direction)
    {
        if (direction == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (direction == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

}
