using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using AK.Wwise;
public class GrenadierAudioWwise : MonoBehaviour
{
    [Header("FootstepsWalk")] public AK.Wwise.Event Grenadier_Footsteps;
    [Header("FootstepsMelee")] public AK.Wwise.Event Grenadier_FootstepsMelee;
    [Header("AttackMeleeCore")] public AK.Wwise.Event Grenadier_AttackMeleeCore;
    [Header("IdleBreath")] public AK.Wwise.Event Grenadier_IdleBreath;
    [Header("IdleMetal")] public AK.Wwise.Event Grenadier_IdleMetal;
    [Header("IdleVox")] public AK.Wwise.Event Grenadier_IdleVox;
    [Header("PresencesWalk")] public AK.Wwise.Event Grenadier_PresencesWalk;

    public GameObject FootLocationLeft;
    public GameObject FootLocationRight;
    
    public void Grenadier_Footsteps_Play(int value)
    {
        if (value==0)
        {
            Grenadier_Footsteps.Post(FootLocationLeft);
        }
        
        else
        {
            Grenadier_Footsteps.Post(FootLocationRight);
        }
    }
    
    public void Grenadier_FootstepsMelee_Play(int value)
    {
        if (value==0)
        {
            Grenadier_FootstepsMelee.Post(FootLocationLeft);
        }
        
        else
        {
            Grenadier_FootstepsMelee.Post(FootLocationRight);
        }
    }
    
    public void Grenadier_AttackMeleeCore_Play()
    {
        Grenadier_AttackMeleeCore.Post(gameObject);
    }
    
    public void Grenadier_IdleBreath_Play()
    {
        Grenadier_IdleBreath.Post(gameObject);
    }
    
    public void Grenadier_IdleMetal_Play()
    {
        Grenadier_IdleMetal.Post(gameObject);
    }
    
    public void Grenadier_IdleVox_Play()
    {
        Grenadier_IdleVox.Post(gameObject);
    }
    
    public void Grenadier_PresencesWalk_Play()
    {
        Grenadier_PresencesWalk.Post(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
