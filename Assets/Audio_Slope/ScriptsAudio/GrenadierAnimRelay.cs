using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadierAnimRelay : MonoBehaviour
{

    public void Grenadier_DeathAnim_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_DeathAnim_Start();
    }
    
    public void Grenadier_TakeDamage_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_TakeDamage_Start();
    }
    
    public void Grenadier_Vox_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_Vox_Start();
    }
    
    public void Grenadier_RangeAttack_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_RangeAttack_Start();
    }
    
    public void Grenadier_ShockWaveAttack_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_ShockWaveAttack_Start();
    }
    
    public void Grenadier_FootstepsSoft_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_FootstepsSoft_Start();
    }
    
    public void Grenadier_TurnAnim_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_TurnAnim_Start();
    }
    
    public void Grenadier_Footsteps_Play(int value)
    {
        GrenadierAudioWwise.Instance.Grenadier_Footsteps_Start(value);
    }
    
    public void Grenadier_FootstepsMelee_Play(int value)
    {
        GrenadierAudioWwise.Instance.Grenadier_FootstepsMelee_Start(value);
    }
    
    public void Grenadier_AttackMeleeCore_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_AttackMeleeCore_Start();
    }

    public void Grenadier_PresencesWalk_Play()
    {
        GrenadierAudioWwise.Instance.Grenadier_PresencesWalk_Start();
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
