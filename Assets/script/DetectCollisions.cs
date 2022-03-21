using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{
    private Gamemanager GameManagerScript;

 
    


    private void Start()
    {

       GameManagerScript = FindObjectOfType<Gamemanager>();

    }
    private void OnCollisionEnter(Collision otherCollider)
    {   
      // si chocan se destruyen los dos y suma 2
        if (gameObject.CompareTag("Obstacle") && otherCollider.gameObject.CompareTag("proyectil"))
        {
            
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
            Debug.Log($"+2");
            GameManagerScript.contador();
           
            

        }
        // si el player choca con el recolectable,desparacece el recolectable y suma 1
        if (gameObject.CompareTag("Player") && otherCollider.gameObject.CompareTag("recolectable"))
        {

            Destroy(otherCollider.gameObject);
            Debug.Log($"+1");
            GameManagerScript.contador();
            

        }

      
       
    }
}
