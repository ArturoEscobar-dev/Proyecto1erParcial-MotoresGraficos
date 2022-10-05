using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{
    [SerializeField] private GameObject buttonOn;
    [SerializeField] private int time = 0;
    [SerializeField] private GameObject[] obstacle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Hola");
            StartCoroutine(ActivateButton(time));
        }
    }

    IEnumerator ActivateButton(int time)
    {
        buttonOn.SetActive(false);
        obstacle[0].SetActive(false);
        obstacle[1].SetActive(false);
        obstacle[2].SetActive(false);
        yield return new WaitForSeconds(time);
        buttonOn.SetActive(true);
        obstacle[0].SetActive(true);
        obstacle[1].SetActive(true);
        obstacle[2].SetActive(true);
        StopCoroutine(ActivateButton(time));
    }


    }




