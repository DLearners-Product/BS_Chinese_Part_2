using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class Quiz_controller : MonoBehaviour
{
    
    private static Quiz_controller instance;
    public static Quiz_controller Instance { get { return instance; } }
    public GameObject[] Q;
    public GameObject currentSlide;
    public GameObject outroSlide;
    public GameObject instructionOverlay;
    public AudioClip[] questionClips;
    public Button nextbutton;
    public Button instructionButton;
    public Sprite instructionSprite;
    public Sprite closeSprite;
    private int i;
    private bool isOverlay;
    public Color correctAnsColor, _correctAnsColor;
    public TextMeshProUGUI count;
    public static int Q_Count = 1;
    public AudioClip instructionClip;
    public AudioClip correctClip;
    public AudioClip wrongClip;
   


    private void Awake()
    {
        if (instance)
            Destroy(this.gameObject);

        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        i = 0;
        nextbutton.gameObject.SetActive(false);
        count.text = Q_Count + " / 5";
        SoundManager.Instance.Play(questionClips[i]);
        instructionOverlay.SetActive(false);
        isOverlay = false;
    }

    private void Update()
    {
        if (Q_Count < 6)
        {
            count.text = Q_Count + " / 5";
        }
        else
        {
            Q_Count = 0;
        }
    }

    public void OnNextButtonClick()
    {
        if (i < Q.Length)
        {
            i++;
            if (i == Q.Length)
            {
                i = 0;
                Q_Count = 1;
                currentSlide.SetActive(false);
                outroSlide.SetActive(true);
                nextbutton.gameObject.SetActive(false);
                return;
            }
            Q[i-1].SetActive(false);
            Q[i].SetActive(true);
            nextbutton.gameObject.SetActive(false);
            SoundManager.Instance.Play(questionClips[i]);
            Q_Count++;


        }

        else { return; }  
    }
    // Function to check correct answer
    public void CheckCorrectAnswer()
    {
        Debug.Log("check CheckCorrectAnswer");
        GameObject selectedOption = Q[i].transform.Find("Options_Image_holder").GetComponent<ToggleGroup>().ActiveToggles().FirstOrDefault().gameObject;
        if (selectedOption.name.Contains("Answer") && i< Q.Length)
        {
            nextbutton.gameObject.SetActive(true);
            SoundManager.Instance.PlayMusic(correctClip);
            
        }
        else
        {
            SoundManager.Instance.PlayMusic(wrongClip);
        }
    }

    public void OnInstructionButtonClick()
    {
        if(!isOverlay)
        {
            isOverlay = true;
            instructionOverlay.SetActive(true);
            SoundManager.Instance.Play(instructionClip);
            instructionButton.gameObject.GetComponent<Image>().sprite = closeSprite;
        }
        else
        {
            isOverlay = false;
            instructionOverlay.SetActive(false);
            SoundManager.Instance.Stop();
            instructionButton.gameObject.GetComponent<Image>().sprite = instructionSprite;

        }
       

    }

   
}
