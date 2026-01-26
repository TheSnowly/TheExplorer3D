using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTriggerEnter : MonoBehaviour
{
    public AK.Wwise.Event eventToPlay;

    private void OnTriggerEnter(Collider other)
    {
       eventToPlay.Post(other.gameObject);
    }
}
