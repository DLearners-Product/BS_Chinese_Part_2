using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
   
    void Start()
    {
        correctanswercount = 0;
        nextButton.gameObject.SetActive(false);
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
    }

    public void OnNextButtonClick()
    {
        currentSlide.SetActive(false);
        draganddropSlide.SetActive(true);
        
    }
}
