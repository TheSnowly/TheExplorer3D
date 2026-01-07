using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{

    public AK.Wwise.Event walkEvent;
    public AK.Wwise.Event landEvent;
    public AK.Wwise.Event jumpEvent;
    public AK.Wwise.Event rollEvent;

    // Start is called before the first frame update
    public void AudioWalk()
    {
        walkEvent.Post(gameObject);
    }

    public void AudioLand()
    {
        landEvent.Post(gameObject);
    }

    public void AudioJump()
    {
        jumpEvent.Post(gameObject);
    }

    public void AudioRoll()
    {
        rollEvent.Post(gameObject);
    }
}
