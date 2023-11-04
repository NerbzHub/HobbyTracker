using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Date : MonoBehaviour
{

    public TMPro.Text uiText = null;

    // Start is called before the first frame update
    void Start()
    {
        //var displayDate = 

        string date = DateTime.Now.ToString("mm:dd:yyyy");

        date = DateTime.Now.ToString("dd/MM/yyyy");

        Debug.Log(date);


        //displayDate.text = date;
    

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Gets Date and Allocates the text on top for it
    // and sets the correct buttons
    void GetDate()
    {
        

    }
}
