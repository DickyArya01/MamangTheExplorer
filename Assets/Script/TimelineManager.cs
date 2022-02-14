using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject script;

    // Update is called once per frame
    void Start()
    {
        script.GetComponent<PlayerMovement>().enabled = false;
    }

    void Update()
    {
        if(director.state != PlayState.Playing)
        {
            script.GetComponent<PlayerMovement>().enabled = true;

        } 
    }
}
