using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
           Play();
       }
       if(Input.GetKeyDown(KeyCode.Q))
       {
           quit();
       }

    }
    private void Play()
    {
        SceneManager.LoadScene(1);
    }

    private void quit()
    {
        Application.Quit();
    }


    
}
