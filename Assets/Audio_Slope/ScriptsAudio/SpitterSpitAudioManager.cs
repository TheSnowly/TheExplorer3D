using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterSpitAudioManager : MonoBehaviour
{
    public AK.Wwise.Event eventSpitterProjectileLP;
    public AK.Wwise.Event eventSpitterProjectileImpact;

    public void AudioSpitterProjectileLP()
    {
        eventSpitterProjectileLP.Post(gameObject);
    }

    public void AudioSpitterProjectileImpact(GameObject emitter)
    {
        eventSpitterProjectileImpact.Post(emitter);
    }
}
