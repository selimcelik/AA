using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunyoneticisi : MonoBehaviour
{
    GameObject donencember;
    GameObject anacember;
    public Animator animator;
    public Text donencemberlevel;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kactanekucukcemberolsun;
    bool kontrol = true;

    void Start()
    {
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));
        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
        donencemberlevel.text = SceneManager.GetActiveScene().name;

        if (kactanekucukcemberolsun < 2)
        {
            bir.text = kactanekucukcemberolsun + "";
        }
        else if (kactanekucukcemberolsun < 3)
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
        }
        else
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
            uc.text = (kactanekucukcemberolsun - 2) + "";
        }

    }
    public void kucukcemberlerdetextgosterme()
    {
        kactanekucukcemberolsun--;
        if (kactanekucukcemberolsun < 2)
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = "";
            uc.text = "";
        }
        else if (kactanekucukcemberolsun < 3)
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
        }
        else
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
            uc.text = "";
        }
        if (kactanekucukcemberolsun==0)
        {
            StartCoroutine(yenilevel());
        }
    }
    IEnumerator yenilevel()
    {   
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        if (kontrol)
        {
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
    }
    public void OyunBitti()
    {
        StartCoroutine(CagrilanMetot());
    }
    IEnumerator CagrilanMetot()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        animator.SetTrigger("oyunbitti");
        kontrol = false;

        yield return new WaitForSeconds(1); // 1 saniye bekletiyoruz

        SceneManager.LoadScene("AnaMenu");
    }
}
