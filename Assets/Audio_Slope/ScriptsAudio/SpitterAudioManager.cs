using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterAudioManager : MonoBehaviour
{
    public AK.Wwise.Event eventSpitterAttackSpit;
    public AK.Wwise.Event eventSpitterAttackCharge;
    public AK.Wwise.Event eventSpitterVoiceSpotted;
    public AK.Wwise.Event eventSpitterVoiceIdle;
    public AK.Wwise.Event eventSpitterDeath;
    public AK.Wwise.Event eventFT;

    public void AudioSpitterAttackSpit()
    {
        eventSpitterAttackSpit.Post(gameObject);
    }

    public void AudioSpitterAttackCharge()
    {
        eventSpitterAttackCharge.Post(gameObject);
    }

    public void AudioVoiceSpotted()
    {
        eventSpitterVoiceSpotted.Post(gameObject);
    }

    public void AudioVoiceIdle()
    {
        eventSpitterVoiceIdle.Post(gameObject);
    }

    public void AudioSpitterDeath()
    {
        eventSpitterDeath.Post(gameObject);
    }

    public void AudioFT()
    {
        eventFT.Post(gameObject);
    }

}
