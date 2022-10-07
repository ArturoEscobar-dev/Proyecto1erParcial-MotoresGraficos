using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] RawImage[] hearts;
    public GameObject diePanel;
    private int healthCount;
    public bool inmunity;
    public float inmunityTime;
    void Start()
    {
        healthCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        switch (healthCount)
        {
            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false;
                break;
            case 1:
                hearts[1].GetComponent<RawImage>().enabled = false;
                break;
            case 2:
                hearts[2].GetComponent<RawImage>().enabled = false;
                break;
        }
        if (healthCount <= 0)
        {
            diePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" && !inmunity)
        {
            healthCount--;
            StartCoroutine(Inmunity());
        }
    }
    IEnumerator Inmunity()
    {
        inmunity = true;
        GetComponent<SpriteRenderer>().material = GetComponent<EffectBlink>().blink;
        yield return new WaitForSeconds(inmunityTime);
        GetComponent<SpriteRenderer>().material = GetComponent<EffectBlink>().original;
        inmunity = false;
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
