using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class row : MonoBehaviour
{
    float x = 0.00025f;
    // Start is called before the first frame update
    // public int stop = 0;
    RectTransform rect;
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    public void startRotating(int stop)
    {
        StartCoroutine(rotate(10));
        StartCoroutine(rotate(stop));

    }

    IEnumerator rotate(int stop)
    {
        for (int i = 0 ; i < 350 ; i++ ){
            //  if (transform.position.y >= -0.08f && transform.position.y <= -0.48f ){
            //     print("hello");
            //     break; //cotton candy break
            //  }
            float current = Mathf.Round(rect.position.y * 100f) / 100f;
            if (current == -0.99f && stop == 3 ){
                print("marsh");
                break; //marsh  break
            }
            if (current == 0.56f && stop == 1){
                print("gumdrop");
                break; //gumdrop  break
            }
            
            
            if (current == -0.19f && stop == 2){
                print("cotton candy");
                break; //cotton candy  break
            }

             
            if (current == 1.31f && stop == 0){
                print("chocolate");
                break; //choclate break
            }

             
            if (current == -1.74f && stop == 4){
                print("candy");
                break; //candy  break
            }

             
            if (current == -2.54f && stop == 5){
                print("lollipop");
                break; //lollipop  break
            }

            //print(current);
            if(rect.position.y <= -2.80){
            rect.position = new Vector2(rect.position.x, 1.31f);
   
            }
            
            rect.position = new Vector2(rect.position.x,rect.position.y - .05f);
            yield return new WaitForSeconds(x);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
