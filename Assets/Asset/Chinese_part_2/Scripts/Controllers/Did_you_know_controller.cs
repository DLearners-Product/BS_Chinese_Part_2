﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Did_you_know_controller : MonoBehaviour
{
    public Button nextButton;
    public Button backButton;
    public GameObject[] contents;
    private int i;

    public void Start()
    {
        i = 0;
        contents[i].SetActive(true);
        backButton.gameObject.SetActive(false);

    }

    public void OnNextButtonClick()
    {
        SoundManager.Instance.EffectsSource.Stop();
        if (i < contents.Length)
        {
            i++;
            contents[i - 1].SetActive(false);
            contents[i].SetActive(true);
        }

        if (i == contents.Length - 1)
        {
            nextButton.gameObject.SetActive(false);
            backButton.gameObject.SetActive(true);
        }
        if (i == 0)
        {
            backButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(true);
        }

        else
        {
            return;
        }

    }

    public void OnBackButtonClick()
    {
        SoundManager.Instance.EffectsSource.Stop();
        if (i > 0)
        {
            i--;
            contents[i + 1].SetActive(false);
            contents[i].SetActive(true);
        }

        if (i == contents.Length - 1)
        {
            nextButton.gameObject.SetActive(false);
            backButton.gameObject.SetActive(true);
        }
        if (i == 0)
        {
            backButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(true);
        }

        else
        {
            return;
        }

    }
}
