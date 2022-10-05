using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    [SerializeField] private Camera cam;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(1.02f, 0.53f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(9.9f, -6.05f, 0f);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area2")
        {
            Vector3 camPosition = new Vector3(1.02f, -21.05f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(1.84f, -12.63f, 0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area3")
        {
            Vector3 camPosition = new Vector3(-36.46f, -1.24f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-21.98f, 0.74f, 0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area4")
        {
            Vector3 camPosition = new Vector3(-36.46f, -1.24f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-21.98f, -3.35f, 0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area5")
        {
            Vector3 camPosition = new Vector3(1.02f, 0.53f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-12.26f, -4f, 0f);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area6")
        {
            Vector3 camPosition = new Vector3(1.02f, -21.05f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-12.58f, -16.89f, 0);
            this.transform.position = playerPosition;
        }
    }
}
