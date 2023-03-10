using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DidyouKnowAudioPlayer : MonoBehaviour
{
    public Button playButton;
    public Sprite playSprite;
    public Sprite pauseSprite;
    public AudioClip[] contentClips;
    private bool isPlaying;
    float timer;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        SoundManager.Instance.EffectsSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;
            if (timer >= contentClips[index].length + 2)
            {
                index++;
                if (index >= contentClips.Length) index = 0; // To loop
                SoundManager.Instance.EffectsSource.clip = contentClips[index];
                timer = 0;
                isPlaying = false;
                playButton.gameObject.GetComponent<Image>().sprite = playSprite;

            }
        }
    }

    public void PlayPause()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            playButton.gameObject.GetComponent<Image>().sprite = pauseSprite;
            SoundManager.Instance.Play(contentClips[index]);
            Debug.Log("Play");
        }
        else
        {
            isPlaying = false;
            playButton.gameObject.GetComponent<Image>().sprite = playSprite;
            SoundManager.Instance.Pause();
            Debug.Log("Pause");
        }
    }
}
