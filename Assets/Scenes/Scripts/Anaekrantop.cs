using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anaekrantop : MonoBehaviour
{
    public SpriteRenderer toprenderer;
    public int skor = 0;
    private int rekor;
    public TextMeshProUGUI hightscore;

    void Start()
    {
    

        if (PlayerPrefs.HasKey("rekor"))
        {
            rekor = PlayerPrefs.GetInt("rekor");
            hightscore.text = "Rekor:" + rekor.ToString();
        }

        else
        {
            rekor = 0;
        }



    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "kenar")

        {
        
            if (toprenderer.color == temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
              

                if (skor > rekor)
                {

                    rekor = skor;

                    hightscore.text = "Rekor:" + rekor.ToString();

                    PlayerPrefs.SetInt("rekor", rekor);
                }
            }

          

        }



    }


    



}
