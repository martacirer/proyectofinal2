using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    public float speed = 10f;

    private float xRange = 16;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // movimiento horizontal del player
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        // limite de pantalla derecho (que lo determina xRange)
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

        // limite pantalla izquierdo
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
        }
        


    }
}
