using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playequit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            loadScene();
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            stop();
        }
            
    }
    public void loadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void stop()
    {
        Application.Quit();
    }
}
