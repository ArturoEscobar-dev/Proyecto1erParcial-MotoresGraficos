using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject logo;
    [SerializeField] private GameObject play;
    [SerializeField] private GameObject options;
    [SerializeField] private GameObject exit;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void Start()
    {
        LeanTween.scale(logo, new Vector3(0.6846446f, 0.6846446f, 0.6846446f), 1f).setEase(LeanTweenType.easeInExpo).setDelay(0.2f);
        LeanTween.scale(play, new Vector3(0.4830493f, 0.4830493f, 0.4830493f), 1f).setEase(LeanTweenType.easeInExpo).setDelay(1f);
        LeanTween.scale(options, new Vector3(0.4830493f, 0.4830493f, 0.4830493f), 1f).setEase(LeanTweenType.easeInExpo).setDelay(1f);
        LeanTween.scale(exit, new Vector3(0.4830493f, 0.4830493f, 0.4830493f), 1f).setEase(LeanTweenType.easeInExpo).setDelay(1f);
    }
}
