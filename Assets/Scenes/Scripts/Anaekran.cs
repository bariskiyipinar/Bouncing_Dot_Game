using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.PackageManager;
using TMPro;

public class Anaekran : MonoBehaviour
{
    private int rekor;
    public TextMeshProUGUI hightscore;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(1);
        }
        PlayerPrefs.SetInt("rekor", rekor);



    }
}