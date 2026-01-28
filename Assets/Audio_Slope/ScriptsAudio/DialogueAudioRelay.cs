using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAudioRelay : MonoBehaviour
{
    public void UI_DialogueOpen_Play()
    {
        UIAudioWwise.Instance.UI_DialogueOpen_Play();
    }

    public void UI_DialogueClose_Play()
    {
        UIAudioWwise.Instance.UI_DialogueClose_Play();
    }
}
