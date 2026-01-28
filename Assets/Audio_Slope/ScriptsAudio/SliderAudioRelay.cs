using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderAudioRelay : MonoBehaviour
{
    ///////////////// HEADERS /////////////////
    
    [Header("RTPC Names (match Wwise exactly)")]
    [SerializeField] private string RTPC_SliderVolumeMaster = "RTPC_VolumeMaster";
    [SerializeField] private string RTPC_SliderVolumeMUS = "RTPC_VolumeMUS";
    [SerializeField] private string RTPC_SliderVolumeSFX = "RTPC_VolumeSFX";
    
    ///////////// FONCTIONS ////////////
    
    private bool peutimporte = true;
        
    public void PlaySlider()
    {
        Debug.Log("[WwiseRTPCSlider] PlaySlider() appelé");

        if (peutimporte == true)
        {
            Debug.Log("[WwiseRTPCSlider] peutimporte = TRUE → lancement de la coroutine");
            StartCoroutine(WaitAndPlay());
        }
        else
        {
            Debug.Log("[WwiseRTPCSlider] peutimporte = FALSE → son bloqué (anti-spam)");
            return;
        }
    }

    IEnumerator WaitAndPlay()
    {
        peutimporte = false;
        yield return new WaitForSeconds(0.1f);

        if (UIAudioWwise.Instance == null)
        {
            yield break;
        }
        
        UIAudioWwise.Instance.UI_Slider_Play();
        peutimporte = true;
    }
    
    //////////// RTPC /////////////
    
    /// Set Master Volume (0-100 range recommended)
    public void SetMasterVolume(float value)
    {
        AKRESULT result = AkSoundEngine.SetRTPCValue(RTPC_SliderVolumeMaster, value);
    }

   
    /// Set Music Volume (0-100 range recommended)
  
    public void SetMusicVolume(float value)
    {
        AKRESULT result = AkSoundEngine.SetRTPCValue(RTPC_SliderVolumeMUS, value);
    }

    
    /// Set SFX Volume (0-100 range recommended)
   
    public void SetSFXVolume(float value)
    {
        AKRESULT result = AkSoundEngine.SetRTPCValue(RTPC_SliderVolumeSFX, value);
        
    }
}
