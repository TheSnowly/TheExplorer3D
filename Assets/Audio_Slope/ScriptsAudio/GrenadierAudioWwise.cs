using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using AK.Wwise;
public class GrenadierAudioWwise : MonoBehaviour
{
    public static GrenadierAudioWwise Instance;
    
    [Header("FootstepsWalk")] public AK.Wwise.Event Grenadier_Footsteps;
    [Header("FootstepsMelee")] public AK.Wwise.Event Grenadier_FootstepsMelee;
    [Header("AttackMeleeCore")] public AK.Wwise.Event Grenadier_AttackMeleeCore;
    [Header("IdleBreath")] public AK.Wwise.Event Grenadier_IdleBreath;
    [Header("IdleMetal")] public AK.Wwise.Event Grenadier_IdleMetal;
    [Header("IdleVox")] public AK.Wwise.Event Grenadier_IdleVox;
    [Header("PresencesWalk")] public AK.Wwise.Event Grenadier_PresencesWalk;
    [Header("DeathAnim")] public AK.Wwise.Event Grenadier_DeathAnim;
    [Header("Vox")] public AK.Wwise.Event Grenadier_Vox;
    [Header("FootstepsSoft")] public AK.Wwise.Event Grenadier_FootstepsSoft;
    [Header("TurnAnim")] public AK.Wwise.Event Grenadier_TurnAnim;
    [Header("TurnAnim")] public AK.Wwise.Event Grenadier_LightBall_End;
    [Header("TurnAnim")] public AK.Wwise.Event Grenadier_IdleBreath_Stop;
    
    [Header("TakeDamage")] public AK.Wwise.Event Grenadier_TakeDamage;
    [Header("RangeAttack")] public AK.Wwise.Event Grenadier_RangeAttack;
    [Header("BallExplosion")] public AK.Wwise.Event Grenadier_BallExplosion;
    [Header("BallBounce")] public AK.Wwise.Event Grenadier_BallBounce;
    [Header("ShockWaveAttack")] public AK.Wwise.Event Grenadier_ShockWaveAttack;
    
    public GameObject FootLocationLeft;
    public GameObject FootLocationRight;
    public GameObject AS_GrenadierVox;
    public GameObject AS_SphereAudioEmitter;
    public GameObject AS_GrenadeRangeAttack;
    
    public AK.Wwise.Switch SW_AttackMelee;
    public AK.Wwise.Switch SW_Death;
    public AK.Wwise.Switch SW_AttackRange_Grenade;
    public AK.Wwise.Switch SW_AttackRange_ShockWave;
    public AK.Wwise.Switch SW_Pursuit;
    public AK.Wwise.Switch SW_Shield;
    public AK.Wwise.Switch SW_TakeDamage;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    /////////////////// Fonctions //////////////////////
   
    public void SetVoxPursuit()
    {
        SW_Pursuit.SetValue(AS_GrenadierVox);
    }
    public void SetVoxShield()
    {
        SW_Shield.SetValue(AS_GrenadierVox);
    }
    public void Grenadier_DeathAnim_Play()
    {
        SW_Death.SetValue(AS_GrenadierVox);
        Grenadier_DeathAnim.Post(gameObject);
    }
    
    public void Grenadier_TakeDamage_Play()
    {
        SW_TakeDamage.SetValue(AS_GrenadierVox);
        Grenadier_Vox.Post(AS_GrenadierVox);
        Grenadier_TakeDamage.Post(gameObject);
    }
    
    public void Grenadier_Vox_Play()
    {
        Grenadier_Vox.Post(AS_GrenadierVox);
    }
    
    public void Grenadier_RangeAttack_Play()
    {
        Grenadier_RangeAttack.Post(gameObject);
    }
    
    public void Grenadier_ShockWaveAttack_Play()
    {
        Grenadier_ShockWaveAttack.Post(gameObject);
    }
    
    public void Grenadier_BallExplosion_Play(GameObject emitter)
    {
        Grenadier_BallExplosion.Post(emitter);
    }
    
    public void Grenadier_BallBounce_Play(GameObject emitter)
    {
        Grenadier_BallBounce.Post(emitter);
    }
    
    public void Grenadier_FootstepsSoft_Play()
    {
        Grenadier_FootstepsSoft.Post(FootLocationRight);
    }
    
    public void Grenadier_TurnAnim_Play()
    {
        Grenadier_TurnAnim.Post(AS_GrenadierVox);
    }
    
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
        SW_AttackMelee.SetValue(gameObject);
        Grenadier_AttackMeleeCore.Post(gameObject);
    }
    
    public void Grenadier_IdleBreath_Play()
    {
        Grenadier_IdleBreath.Post(gameObject);
    }
    
    public void Grenadier_IdleVox_Play()
    {
        Grenadier_IdleVox.Post(gameObject);
    }
    
    public void Grenadier_PresencesWalk_Play()
    {
        Grenadier_PresencesWalk.Post(gameObject);
    }
    
    public void Grenadier_LightBall_Stop()
    {
        Grenadier_LightBall_End.Post(AS_SphereAudioEmitter);
        Grenadier_IdleBreath_Stop.Post(AS_SphereAudioEmitter);
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
