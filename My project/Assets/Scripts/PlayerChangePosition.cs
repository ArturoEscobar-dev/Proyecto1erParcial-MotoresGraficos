using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    [SerializeField] private Camera cam;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Area2")
        {
            Vector3 camPosition = new Vector3(0, -20.73f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-0.04f, -12.48f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(0, 0.11f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-1.21f, -6.29f, 0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area8")
        {
            Vector3 camPosition = new Vector3(-35.2f, 2.57f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-35.13f, 11.05f, -0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area3")
        {
            Vector3 camPosition = new Vector3(0, 0.11f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-1.21f, -6.29f, 0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area4")
        {
            Vector3 camPosition = new Vector3(0, 0.11f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-1.21f, -6.29f, 0);
            this.transform.position = playerPosition;
        }
        if (collision.gameObject.tag == "Area5")
        {
            Vector3 camPosition = new Vector3(0, 0.11f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-1.21f, -6.29f, 0);
            this.transform.position = playerPosition;
        }
    }
}
