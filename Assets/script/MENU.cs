using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
