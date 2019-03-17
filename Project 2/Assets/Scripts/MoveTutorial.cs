using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTutorial : MonoBehaviour
{
    [Range(0,5)]
    public float speed;
    [Range(0, 1)]
    public float directionChangeChance;

    private float actualSpeed;
    private float edgeValue = 8.87f;
    Vector3 pos;

    


    // Start is called before the first frame update
    void Start()
    {
        actualSpeed = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos = transform.position;

        if (Mathf.Abs(actualSpeed) != speed)
        {
            if (Mathf.Sign(actualSpeed) == -1 || Mathf.Sign(actualSpeed) == 0)
            {
                actualSpeed = speed * -1;
            }
            else
            {
                actualSpeed = speed;
            }
        }

        transform.position += Vector3.right * actualSpeed;

        if (Random.value <= directionChangeChance)
        {
            actualSpeed *= -1;
        }

        if (pos.x < -edgeValue || pos.x > edgeValue)
        {
            actualSpeed *= -1;
        }

        
    }

}
