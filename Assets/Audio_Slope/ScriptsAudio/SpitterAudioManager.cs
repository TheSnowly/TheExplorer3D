using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterAudioManager : MonoBehaviour
{
    public AK.Wwise.Event eventSpitterAttackSpit;
    public AK.Wwise.Event eventSpitterAttackCharge;
    public AK.Wwise.Event eventSpitterVoiceSpotted;
    public AK.Wwise.Event eventSpitterDeath;
    public AK.Wwise.Event eventSpitterFTWalk;

    public void AudioSpitterAttackSpit()
    {
        eventSpitterAttackSpit.Post(gameObject);
    }

    public void AudioSpitterAttackCharge()
    {
        eventSpitterAttackCharge.Post(gameObject);
    }

    public void AudioSpitterVoiceSpotted()
    {
        eventSpitterVoiceSpotted.Post(gameObject);
    }

    public void AudioSpitterFTWalk()
    {
        eventSpitterFTWalk.Post(gameObject);
    }


}
