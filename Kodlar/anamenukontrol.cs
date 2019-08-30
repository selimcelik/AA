using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenukontrol : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }
    public void oyunaGit()
    {
        int kayitlilevel = PlayerPrefs.GetInt("kayit"); // Burada kayıt yaptık.
        if (kayitlilevel == 0)
        {
            SceneManager.LoadScene(kayitlilevel+1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }
    public void cik()
    {
        Application.Quit();
    }
}
