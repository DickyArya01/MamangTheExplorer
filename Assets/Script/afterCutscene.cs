using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class afterCutscene : MonoBehaviour
{
    public PlayableDirector director;
    public int idSceneToLoad;
    // Update is called once per frame
    void Update()
    {
        if(director.state != PlayState.Playing)
        {
            SceneManager.LoadScene(idSceneToLoad);
        } 
    }
}
