using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBons : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -10f;

    private float xLim = -10f;

    private Gamemanager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        //para que desaparezca despues de salir de camara
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        //para que desaparezca despues de salir de camara
        if (transform.position.z < lowerLim)
        {
            
            Destroy(gameObject);
            
        }

        if(transform.position.z < xLim)
        {
            Debug.Log($"GAME OVER");
            Time.timeScale = 0;
            gameManager.isGameOver = true;
        }
    }
}
