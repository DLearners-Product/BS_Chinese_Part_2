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
    public Button nextbutton;
    private int i;
    public Color correctAnsColor, _correctAnsColor;
    public static int Q_Count = 1;
    public TextMeshProUGUI count;


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
        
        // counter implementation using playerprefs
        if (PlayerPrefs.GetInt("counter") != 0)
        {
            int x = PlayerPrefs.GetInt("counter");
            count.text = x + "/ 5";
        }

    }

    public void OnNextButtonClick()
    {
        if (i < Q.Length)
        {
            i++;
            Q[i-1].SetActive(false);
            Q[i].SetActive(true);
            nextbutton.gameObject.SetActive(false);
            //counter logic
            Q_Count++;
            PlayerPrefs.SetInt("counter", Q_Count);

        }
        if(i== Q.Length-1)
        {
            nextbutton.gameObject.SetActive(false);
            PlayerPrefs.DeleteAll();
        }

        else { return; }  
    }
    // Function to check correct answer
    public void CheckCorrectAnswer()
    {
        Debug.Log("check CheckCorrectAnswer");
        GameObject selectedOption = Q[i].transform.Find("Options_Image_holder").GetComponent<ToggleGroup>().ActiveToggles().FirstOrDefault().gameObject;
        if (selectedOption.name.Contains("Answer") && i< Q.Length-1)
        {
            nextbutton.gameObject.SetActive(true);
        }
    }

   
}
