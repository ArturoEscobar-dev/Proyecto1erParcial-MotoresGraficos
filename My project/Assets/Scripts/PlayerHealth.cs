using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] RawImage[] hearts;
    private int healthCount;
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
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            healthCount--;
        }
    }

}
