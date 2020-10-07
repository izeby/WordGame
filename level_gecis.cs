using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level_gecis : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nasiloynanir()
    {
        SceneManager.LoadScene("nasiloynanir"); // birsonraki sahneyi yükler

    }
    public void bolum_bir ()
    {
        SceneManager.LoadScene("bolumbir"); // birsonraki sahneyi yükler

    }
    public void bolum_iki()
    {
        SceneManager.LoadScene("bolumiki");

    }
    public void bolum_uc()
    {
        SceneManager.LoadScene("bolumuc");

    }
    public void bolum_dort()
    {
        SceneManager.LoadScene("bolumdort");

    }
    public void bolum_bes()
    {

        SceneManager.LoadScene("bolumbes");
    }
    public void bolum_alti()
    {

        SceneManager.LoadScene("bolumalti");
    }
    public void bolum_yedi()
    {

        SceneManager.LoadScene("bolumyedi");
    }
    public void bolum_sekiz()
    {

        SceneManager.LoadScene("bolumsekiz");
    }
    public void bolum_dokuz()
    {

        SceneManager.LoadScene("bolumdokuz");
    }
    public void anamenu()
    {

        SceneManager.LoadScene("anamenu");
    }
}
