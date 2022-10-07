using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    private bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Play();
            }
            else
            {
                Pause();
            }
        }
    }

    void Play()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
