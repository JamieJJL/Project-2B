using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [Range(0, 8)]
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        transform.Translate(movement, 0, 0);

        float xAxis = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector3(xAxis, transform.position.y, transform.position.z);
    }
}
