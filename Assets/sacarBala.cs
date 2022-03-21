using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sacarBala : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
        // Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position,
                transform.rotation);
        }
    }
}
