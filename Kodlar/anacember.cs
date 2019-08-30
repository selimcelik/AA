using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacember : MonoBehaviour
{
    public GameObject kucukcember;
    GameObject OyunYonetici;
    void Start()
    {
        OyunYonetici = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            kucukcemberolustur();
        }    
    }
    void kucukcemberolustur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);
        OyunYonetici.GetComponent<oyunyoneticisi>().kucukcemberlerdetextgosterme();
    }
}
