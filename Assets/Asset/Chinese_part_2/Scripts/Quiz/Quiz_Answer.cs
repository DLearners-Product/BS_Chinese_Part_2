using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz_Answer : MonoBehaviour
{
    public Image color_image;

    // Changing color to red and green to highlight correct and wrong answers
    public void OnCorrectAnswerClick()
    {
        if(this.gameObject.name ==  Quiz_controller.Instance.correctanswer.name)
        {
            color_image.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
        else
        {
            color_image.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }
}
