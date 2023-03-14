using UnityEngine;
using UnityEngine.UI;

public class GreatwallActivityController : MonoBehaviour
{
    public Image greatWall;
    public Image Map;
    public Image MapZoomed;
    public AudioClip correctClip;
    public AudioClip wrongClip;


    private void Start()
    {
        greatWall.color = new Color32(255, 255, 255, 0);
    }

    public void OnGreatwallClick()
    {
        greatWall.color = new Color32(255, 255, 255, 255);
        SoundManager.Instance.Play(correctClip);
        Invoke("ZoomedMapEnabler", 2f);
    }

    public void OnMapClick()
    {
        SoundManager.Instance.Play(wrongClip);
    }

    public void ZoomedMapEnabler()
    {
        MapZoomed.gameObject.SetActive(true);
        Map.gameObject.SetActive(false);
    }


}
