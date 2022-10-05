using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirObjetos : MonoBehaviour
{

    private bool sucedio;
    public GameObject obstaculo;
    public GameObject efecto1;
    public GameObject efecto2;
    public Sprite nuevoSprite;
    private BoxCollider2D bc2d;
    public void Start()
    {

    }
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
            obstaculo.GetComponent<SpriteRenderer>().sprite = nuevoSprite;
            efecto1.gameObject.SetActive(false);
            efecto2.gameObject.SetActive(false);
            obstaculo.GetComponent<BoxCollider2D>().isTrigger = true;
           
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
