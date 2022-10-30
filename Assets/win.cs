using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class win : MonoBehaviour
{
    private AudioSource source;

    public GameObject[] lights;
    public GameObject text;
    public float waitTillNext = 0.5f;
    public GameObject congrats;
    public GameObject rowSpinnerScript;
    public bool TimeUp = false;
    public  Vector3 textpos; 
    public RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        
        rect = text.GetComponent<RectTransform>();
        textpos =  rect.position;

    }

    public void flashLights() {
        print("I am in flashing lights");
                // source.PlayOneShot(win1);
        StartCoroutine(waitanddFlash());
    }

    IEnumerator waitanddFlash() {
        foreach(GameObject light in lights) {
            print(rowSpinnerScript.GetComponent<generaterow>().timeRemaining);
            if (rowSpinnerScript.GetComponent<generaterow>().timeRemaining <= 0)
            {
                print("HELLOOOOO");
                print(rowSpinnerScript.GetComponent<generaterow>().timeRemaining);
                TimeUp = true;
                break;
            }
            light.GetComponent<Image>().color = Color.white;
            yield return new WaitForSeconds(waitTillNext);
            light.GetComponent<Image>().color = Color.gray;
            yield return new WaitForSeconds(waitTillNext);
        }
        if(TimeUp == false){
            Array.Reverse(lights);
        StartCoroutine(waitanddFlash());
        } 
        
    }

    public void panText() {
        StartCoroutine(waitandPan());
    }

    IEnumerator waitandPan() {
        for (int i = 0; i < 350; i++) {
            if (rowSpinnerScript.GetComponent<generaterow>().timeRemaining <= 0)
            {
                yield break;
            }
            if(rect.position.x <= 1.80){
                rect.position = new Vector2(11.53f, rect.position.y);
   
            }
            
            rect.position = new Vector2(rect.position.x - 0.5f, rect.position.y);
            yield return new WaitForSeconds(0.1f);
        }
        rect.position = textpos;
        yield return new WaitForSeconds(1);
    }

    public void flashCongrats() {
        StartCoroutine(flashCongratsWait());
    }
    IEnumerator flashCongratsWait() {

        for (int i = 0; i < 350; i++) {
            print("hello");
            congrats.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            congrats.SetActive(false);
             print("feafea");
        }
        yield return new WaitForSeconds(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
