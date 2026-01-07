using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using AK.Wwise;
public class GrenadierAudioWwise : MonoBehaviour
{
    [Header("Footsteps")] public AK.Wwise.Event Grenadier_Footsteps;

    public void Grenadier_Footsteps_Play()
    {
        Grenadier_Footsteps.Post(gameObject);
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
