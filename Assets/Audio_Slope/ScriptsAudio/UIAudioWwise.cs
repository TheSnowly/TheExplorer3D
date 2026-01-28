using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using AK.Wwise;
public class UIAudioWwise : MonoBehaviour
{
    public static UIAudioWwise Instance;
    
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
    
    ////////////// Headers /////////////////
    
    [Header("UI_Click")] public AK.Wwise.Event UI_Click;
    [Header("UI_MenuOpen")] public AK.Wwise.Event UI_MenuOpen;
    [Header("UI_MenuClose")] public AK.Wwise.Event UI_MenuClose;
    [Header("UI_DialogueOpen")] public AK.Wwise.Event UI_DialogueOpen;
    [Header("UI_DialogueClose")] public AK.Wwise.Event UI_DialogueClose;
    [Header("UI_Slider")] public AK.Wwise.Event UI_Slider;
    [Header("UI_MouseOver")] public AK.Wwise.Event UI_MouseOver;
    [Header("UI_Back")] public AK.Wwise.Event UI_Back;
    
    ////////////// Fonctions /////////////////
    
    public void UI_Click_Play()
    {
        UI_Click.Post(gameObject);
    }
    
    public void UI_Back_Play()
    {
        UI_Back.Post(gameObject);
    }
    public void UI_MenuOpen_Play()
    {
        UI_MenuOpen.Post(gameObject);
    }
    
    public void UI_MenuClose_Play()
    {
        UI_MenuClose.Post(gameObject);
    }
    
    public void UI_DialogueOpen_Play()
    {
        UI_DialogueOpen.Post(gameObject);
    }
    
    public void UI_DialogueClose_Play()
    {
        UI_DialogueClose.Post(gameObject);
    }
    
    public void UI_Slider_Play()
    {
        UI_Slider.Post(gameObject);
    }
    
    public void UI_MouseOver_Play()
    {
        UI_MouseOver.Post(gameObject);
    }
    //////////////////////////////////////////
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
