using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
    }
    public void oyundan_cik()

    {
        Application.Quit();
    }

    public void oyuna_basla()
    {

        SceneManager.LoadScene("bolumbir");

    }
    //public void nasil_oynanir()
    //{
    //    SceneManager.LoadScene("nasiloynanir");
    //}
}
