using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ganar : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        panel.SetActive(true);
    }

    public void regresarAlMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
