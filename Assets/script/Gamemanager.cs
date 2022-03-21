using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
 
    public TextMeshProUGUI pointText;
    public int Score = 0;
    public GameObject panel;
    public GameObject golem;
    private Animator animator;

    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        panel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            panel.SetActive(true);
            
        }
    }
    public void contador()
    {
        Score ++;
        pointText.text = $"score: {Score}";
    }

    
}
