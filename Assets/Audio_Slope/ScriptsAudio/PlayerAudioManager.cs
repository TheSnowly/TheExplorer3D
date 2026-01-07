using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{

    public AK.Wwise.Event walkEvent;
    public AK.Wwise.Event landEvent;
    public AK.Wwise.Event jumpEvent;
    public AK.Wwise.Event rollEvent;
    public AK.Wwise.Event attackEvent;
    public AK.Wwise.Event attackEndComboEvent;
    public AK.Wwise.Event scuffEvent;
    public AK.Wwise.Event hurtEvent;
    public AK.Wwise.Event deathEvent;
    public AK.Wwise.Event presenceEvent;

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

    public void AudioAttack()
    {
        attackEvent.Post(gameObject);
    }

    public void AudioAttackEndCombo()
    {
        attackEndComboEvent.Post(gameObject);
    }

    public void AudioScuff()
    {
        scuffEvent.Post(gameObject);
    }

    public void AudioHurt()
    {
        hurtEvent.Post(gameObject);
    }

    public void AudioDeath()
    {
        deathEvent.Post(gameObject);
    }

    public void AudioPresence()
    {
        presenceEvent.Post(gameObject);
    }
}
