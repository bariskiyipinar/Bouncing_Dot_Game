using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    private Rigidbody2D topRb;
    public int ZiplamaGucu = 30;
    public Color red, green, purple, blue, yellow, pink;
    public SpriteRenderer toprenderer;
    public TextMeshProUGUI skoryazisi;
    public int skor = 0;
    private int rekor;
    public TextMeshProUGUI hightscore;
    private AudioSource ses;

    void Start()
    {
        ses=GetComponent<AudioSource>();
        topRb = GetComponent<Rigidbody2D>();
        renkver();
        toprenderer = GetComponent<SpriteRenderer>();

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
            topRb.AddForce(Vector2.up * ZiplamaGucu, ForceMode2D.Impulse);

            if (toprenderer.color == temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                ses.Play();
                skor += Random.Range(5, 15);
                    skoryazisi.text = "Skor:" + skor.ToString();

                if (skor > rekor) {
                  
                rekor = skor;

                    hightscore.text = "Rekor:" + rekor.ToString();

                    PlayerPrefs.SetInt("rekor", rekor);
                }
            }

            else if (toprenderer.color != temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }

       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "renkdegistir")
        {
            renkver();
        }
    }


    void Update()
    {
       

    }

 

    private void renkver()
    {
        int renksayisi = Random.Range(1,7);
        switch (renksayisi)
        {
            case 1:
                toprenderer.color = red; break;
            case 2:
                toprenderer.color = green; break;
            case 3:
                toprenderer.color = purple; break; 
            case 4:
                toprenderer.color = blue; break;
            case 5:
                toprenderer.color = yellow; break;
            case 6:
                toprenderer.color = pink; break; 
        }
    }

 

 
}
