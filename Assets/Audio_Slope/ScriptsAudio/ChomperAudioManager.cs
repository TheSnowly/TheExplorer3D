using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperAudioManager : MonoBehaviour
{
    public AK.Wwise.Event eventChomperAttackBite;
    public AK.Wwise.Event eventChomperAttackCharge;
    public AK.Wwise.Event eventChomperDeath;
    public AK.Wwise.Event eventFT;
    public AK.Wwise.Event eventChomperVoiceAttack;
    public AK.Wwise.Event eventChomperVoiceIdle;
    public AK.Wwise.Event eventChomperVoiceSpotted;

    protected bool isDead = false;

    public void AudioChomperAttackBite()
    {
        eventChomperAttackBite.Post(gameObject);
    }

    public void AudioChomperAttackCharge()
    {
        if (!isDead)
        {
            eventChomperAttackCharge.Post(gameObject);
        }
    }

    public void AudioChomperDeath()
    {
        eventChomperDeath.Post(gameObject);
        isDead = true;
    }

    public void AudioFT()
    {
        eventFT.Post(gameObject);
    }

    public void AudioChomperVoiceAttack()
    {
        eventChomperVoiceAttack.Post(gameObject);
    }

    public void AudioVoiceIdle()
    {
        eventChomperVoiceIdle.Post(gameObject);
    }

    public void AudioVoiceSpotted()
    {
        eventChomperVoiceSpotted.Post(gameObject);
    }
}
