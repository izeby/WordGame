using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buton : MonoBehaviour
{
    
    yonetici yonet;
    public Image renk; //buton rengi değişmeli
    RectTransform buyukluk; // yok olma hızının büyüklüğü
    string harf; // butonun ismine erişmek için seçtiğimiz harfler 
    bool harf_verildi = false;  // butonu listeye bir kez yollamamız lazım
    public bool yok_ol = false; // yok etme değişkeni true olduğunda buton yok olacak
    float kuculme_miktari = 0.025f; // yok etme oranımız
    RectTransform aci;
    void Start()
    {
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>(); // yonetici koduna atadık
        renk = GetComponent<Image>(); // renk atadık butona
        buyukluk = GetComponent<RectTransform>(); // yok olma hızını atadık 
        harf = gameObject.name;
        aci = GetComponent<RectTransform>();
       
    }
   
    private void Update()
    {
        if (yonet.tiklandi == false)//ekrana hiç tıklanmadıysa
        {
            harf_verildi = false;
            renk.color = Color.white; //rengi beyaz olsun 
            //oluşan harf sözlükte yoksa iptal olmalı başlangıç haline dönmesi için
        }
        if (yok_ol == true) //Eğer buton yok olacaksa
        {
            renk.color = Color.green;
           
            buyukluk.localScale -= new Vector3(kuculme_miktari, kuculme_miktari, kuculme_miktari); // küçült
            aci.position -= new Vector3(Random.Range (+180f,-180f), Random.Range(180f, -180f), Random.Range(-90f, +90f));
            if (buyukluk.localScale.x <= 0) //ekranda gözükmüyorsa artık o butonu sil
            {
                Destroy(gameObject); // butonu sildik
            }
        }
        
        //else if (yok_ol ==false )
        //{
        //    renk.color = Color.red;

        //}
    }
    public void yesil_ol()
    {
        if (yonet.tiklandi == true) //butonun üstüne tıklandığında
        {
            //renk.color = cam.GetComponent<Camera>().backgroundColor.grayscale(); //rengi değiştir
            renk.color = Color.cyan;

          
            if (harf_verildi == false) //yonetici kısmının içindeki kısma butonu yollarız
            {
                yonet.isaretli_buton_olustur(gameObject);
                harf_verildi = true; // sürekli aynı harfi göndermesin diye
            }
        }
    }

    //public void kirmizi_ol()
    //{
    //    renk.color = Color.red;
    //}
   
   
}
