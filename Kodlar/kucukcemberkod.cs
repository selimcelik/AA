using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = false;
    GameObject OyunYoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        OyunYoneticisi=GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    
    void FixedUpdate()
    {
        if (!hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol = true;
        }
        if (col.tag == "kucukcembertag")
        {
            OyunYoneticisi.GetComponent<oyunyoneticisi>().OyunBitti();

        }
    }
}
