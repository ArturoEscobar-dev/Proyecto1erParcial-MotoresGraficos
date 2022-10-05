using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetosblink : MonoBehaviour
{
    private bool sucedio;
    public GameObject obstaculo;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !sucedio)
        {
            StartCoroutine(blink());
        }
    }
    public void FixedUpdate()
    {
        if (sucedio == true)
        {
            obstaculo.gameObject.SetActive(false);
        }
    }
    IEnumerator blink()
    {
        GetComponent<SpriteRenderer>().material = GetComponent<EffectBlink>().blink;
        yield return new WaitForSeconds(0.5f);
        GetComponent<SpriteRenderer>().material = GetComponent<EffectBlink>().original;
        sucedio = true;
    }
}
