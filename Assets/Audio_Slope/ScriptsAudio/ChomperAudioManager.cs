using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperAudioManager : MonoBehaviour
{
    public AK.Wwise.Event eventChomperAttackBite;
    public AK.Wwise.Event eventChomperAttackCharge;
    public AK.Wwise.Event eventChomperDeath;
    public AK.Wwise.Event eventChomperFTWalk;
    public AK.Wwise.Event eventChomperVoiceAttack;
    public AK.Wwise.Event eventChomperVoiceIdle;
    public AK.Wwise.Event eventChomperVoiceSpotted;

    public void AudioChomperAttackBite()
    {
        eventChomperAttackBite.Post(gameObject);
    }

    public void AudioChomperAttackCharge()
    {
        eventChomperAttackCharge.Post(gameObject);
    }

    public void AudioChomperDeath()
    {
        eventChomperDeath.Post(gameObject);
    }

    public void AudioChomperFTWalk()
    {
        eventChomperFTWalk.Post(gameObject);
    }

    public void AudioChomperVoiceAttack()
    {
        eventChomperVoiceAttack.Post(gameObject);
    }

    public void AudioChomperVoiceIdle()
    {
        eventChomperVoiceIdle.Post(gameObject);
    }

    public void AudioChomperVoiceSpotted()
    {
        eventChomperVoiceSpotted.Post(gameObject);
    }
}
