using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer : MonoBehaviour
{
    public Image correct;
    public Image wrong;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public AudioSource correctAudio;
    public AudioSource wrongAudio;
    // Start is called before the first frame update
    void Start()
    {
        correct.enabled = false;
        wrong.enabled = false;
        if(btn1 != null) btn1.onClick.AddListener(delegate {result(btn1.tag); });
        if(btn2 != null) btn2.onClick.AddListener(delegate {result(btn2.tag); });
        if(btn3 != null) btn3.onClick.AddListener(delegate {result(btn3.tag); });
        if(btn4 != null) btn4.onClick.AddListener(delegate {result(btn4.tag); });
        if(btn5 != null) btn5.onClick.AddListener(delegate {result(btn5.tag); });
        if(btn6 != null) btn6.onClick.AddListener(delegate {result(btn6.tag); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void result(string ans){
        //Debug.Log(ans);
        if(ans=="correct"){
            //Debug.Log(ans);
            correct.enabled = true;
            correctAudio.Play(); 
        }else{
            //Debug.Log(ans);
            wrong.enabled = true;
            wrongAudio.Play();
        }
        
        if(btn1 != null) btn1.interactable = false;
        if(btn2 != null) btn2.interactable = false;
        if(btn3 != null) btn3.interactable = false;
        if(btn4 != null) btn4.interactable = false;
        if(btn5 != null) btn5.interactable = false;
        if(btn6 != null) btn6.interactable = false;
    }
}
