using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEvent : MonoBehaviour
{
    public AK.Wwise.Event eventToPlay;
    public float timeToWait = 0f;

    public void PlayAudioEvent()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timeToWait);
        eventToPlay.Post(gameObject);
    }
}
