using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryActivityController : MonoBehaviour
{

    public Image[] shrtL;
    public Image[] lngL;
    public Sprite lanternGlow;
    public Sprite longLanternGlow;
    public Button nextButton;
    int correctanswercount;
    public GameObject draganddropSlide;
    public GameObject currentSlide;
    public GameObject gameWonOverlay;
    public AudioClip[] instructionClips;
    private int i;
    public static int correctCount = 0;
    public AudioClip VictoryClip;
  
    void Start()
    {
        i = 0;
        correctanswercount = 0;
        nextButton.gameObject.SetActive(false);
        SoundManager.Instance.Stop();
        
    }

  //Functions to change sprite on click
   public void OnShortLanternClick(int i)
    {
        shrtL[i].GetComponent<Image>().sprite = lanternGlow;
        correctanswercount++;
    }
    public void OnLongLanternClick(int i)
    {

        lngL[i].GetComponent<Image>().sprite = longLanternGlow;
        correctanswercount++;

    }

    private void Update()
    {
        if(correctanswercount == 5)
        {
            nextButton.gameObject.SetActive(true);
            correctanswercount = 0;
        }

       if ( correctCount == 20)
        {
            Debug.Log(correctCount);
            Invoke("GameWon", 1f);
            correctCount = 0;
            
        }
    }

    public void OnNextButtonClick()
    {
        draganddropSlide.SetActive(true);
        i++;   
    }
    public void OnInstructionButtonClick()
    {
        SoundManager.Instance.Play(instructionClips[i]);
    }

    public void GameWon()
    {
        gameWonOverlay.SetActive(true);
        SoundManager.Instance.PlayMusic(VictoryClip);

    }
}
