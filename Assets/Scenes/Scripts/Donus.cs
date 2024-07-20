using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Lumin;

public class Donus : MonoBehaviour
{
    private float beklemesüresi = 0.1f;
   

    void Update()
    {
        StartCoroutine(AltigenDonus());
    }

    IEnumerator AltigenDonus()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, 0));
        if(Input.GetMouseButtonDown(0) && mousePos.x>0) {
            transform.Rotate(0, 0, -30);
            yield return new WaitForSeconds(beklemesüresi);
            transform.Rotate(0, 0, -30); 
        }
        else if (Input.GetMouseButtonDown(0) && mousePos.x < 0)
        {
            transform.Rotate(0, 0, 30);
            yield return new WaitForSeconds(beklemesüresi);
            transform.Rotate(0, 0, 30);
        }
    }
}
