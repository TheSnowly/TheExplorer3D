using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    //set the surface type the player is walking on 
    void SetFTSurfaceType()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            AudioSurfaceTypeEnum surfaceType = hit.collider.GetComponent<AudioSurfaceTypeEnum>();
            if (surfaceType == null) return;

            AkSoundEngine.SetSwitch("FT_Type", surfaceType.surfaceType.ToString(), this.gameObject);
        }
    }

    public void AudioWalk()
    {
        SetFTSurfaceType();
        walkEvent.Post(gameObject);
    }

    public void AudioLand()
    {
        SetFTSurfaceType();
        landEvent.Post(gameObject);
    }

    public void AudioJump()
    {
        SetFTSurfaceType();
        jumpEvent.Post(gameObject);
    }

    public void AudioRoll()
    {
        SetFTSurfaceType();
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
        SetFTSurfaceType();
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
