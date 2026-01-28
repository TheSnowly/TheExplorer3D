using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEvent : MonoBehaviour
{
    public AK.Wwise.Event eventToPlay;
    public float timeToWait = 0f;
    public bool PlayOnce = true;

    private bool isAlowedToPlay = true;

    public void PlayAudioEvent()
    {
        if (isAlowedToPlay)
        {
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timeToWait);
        eventToPlay.Post(gameObject);
        if (PlayOnce) 
        { 
            isAlowedToPlay = false;    
        }
    }
}
