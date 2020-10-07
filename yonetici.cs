using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class yonetici : MonoBehaviour
{
   
  
    public string[] sozluk; //sözlüğümüz
    public Text puan_txt;//seçtiğimiz kelimeyi anlık görmek için

    List<GameObject> isaretli_butonlar;//yeşil olan butonları bir listede depolamam lazım ki sonradan silebileyim

    string kelime = null; //mouse ile seçilen kelime başlangıç hali boş 

    public bool tiklandi = false; // butona tıklandığında true olacak

    public GameObject bitti_panel; // oyun tamamlanınca gelecek olan panel
    int puan = 0;
    int bulunan_kelime_sayisi = 0; // eğer sozluğuniçindeki kelime sayısına eşit olursa tüm kelimeleri bulduk anlamına gelir
                                   // dolayısıyla oyun biter
    void Start()
    {
      
        isaretli_butonlar = new List<GameObject>(); // işaretli butonlardan  yeni bir list oluşturduk
    }

    public void isaretli_buton_olustur(GameObject buton)
    {
        isaretli_butonlar.Add(buton); // Buton script dosyasından gelen butonu listeye ekledik 

        kelime = null; // kelimeyi null yaptık

        foreach (GameObject butonlar in isaretli_butonlar)
        {
            kelime = kelime + butonlar.name; // kelimeye sürekli ekledik harfleri
           /* puan_txt.text = kelime;*/ //ekrandan anlık olarak oluşturduğumuz kelimeleri görebiliyor olacağız
        }
    }
    void Update()
    {


        if (Input.GetMouseButtonDown(0))//bir kez çalışacak
        {
            tiklandi = true;
            yazi_olustur();
        }

        if (Input.GetMouseButtonUp(0))// çektiğimiz an bir kez çalışacak
        {
            tiklandi = false;
            yazi_olustur();
            //kirmizi();
            puan_txt.text = puan.ToString();
        }
    }

    void yazi_olustur()
    {
        foreach (string kelimeler in sozluk)//kelimelerin her birine eriştik -zaten anlık olarak harfleri atamıştık 
        {
            if (kelimeler == kelime) //varsa arttır puan
            {
                puan += 100;
                bulunan_kelime_sayisi++;
            
                foreach (GameObject buton in isaretli_butonlar)//işaretli butonu yok ettik.
                {    
                    buton.GetComponent<buton>().yok_ol = true;
                }
               
            }
            //else
            //{
            //    Invoke("kirmizi_ol", 0.5f);
            //}
            
        }
        
        isaretli_butonlar.Clear(); //değişkenin içini temizledik
        kelime = null;//kelimenin içini boşalttık

        if (bulunan_kelime_sayisi == sozluk.Length)//sozluk içindeki kelimelere eşitse bilinen kelimeler artık level bitmiş olur
        {
            bitti_panel.SetActive(true);//paneli açarız
            //sonraki_bolum_bir();
        }
    }
    public void kirmizi_ol()
    {
        foreach (GameObject buton in isaretli_butonlar)//işaretli butonu yok ettik.
        {
            buton.GetComponent<buton>().yok_ol = false;

            buton.GetComponent<Image>().color = Color.red;
        }
    }
    //public void kirmizi()
    //{
    //    foreach (string kelimeler in sozluk)//kelimelerin her birine eriştik -zaten anlık olarak harfleri atamıştık 
    //    {
    //        if (kelimeler != kelime) //varsa arttır puan
    //        {
    //            foreach (GameObject buton in isaretli_butonlar)//işaretli butonu yok ettik.
    //            {
    //                buton.GetComponent<Image>().color = Color.red;
    //            }
    //        }
    //    }
    //}


}
