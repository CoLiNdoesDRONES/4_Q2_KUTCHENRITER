using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    int n = 0;  
    public Text myText;  

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Value: " + n ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up"))
        {
            if(n < 10){ 
            n = n+3;     
            myText.text = "Value: " + n; 
        }   
        if (Input.GetKeyDown("down"))
        
        if(n > 0){ 
            n--;  
            myText.text = "Value: " + n ;}
        }
    }
}