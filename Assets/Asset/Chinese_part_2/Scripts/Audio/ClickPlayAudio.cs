using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlayAudio : MonoBehaviour
{
    public AudioClip audioclip;

    private void Start()
    {
        SoundManager.Instance.EffectsSource.Stop();
    }

    public void Onclick()
    {
        SoundManager.Instance.Play(audioclip);
    }
}
