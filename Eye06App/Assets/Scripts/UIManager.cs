﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panel;

    [SerializeField] TextMeshProUGUI total_text;
    [SerializeField] TextMeshProUGUI debris_name_text;
    [SerializeField] TextMeshProUGUI latitude_text;
    [SerializeField] TextMeshProUGUI longitude_text;
    [SerializeField] TextMeshProUGUI altiitude_text;
    [SerializeField] TextMeshProUGUI epoch_text;

    public void UpdateTotalText(string txt)
    {
        total_text.text = txt;
    }   
    public void UpdateDebrisNameText(string txt)
    {
        debris_name_text.text = txt;
    }    
    public void UpdateLatitudeText(string txt)
    {
        latitude_text.text = txt;
    }   
    public void UpdateLongitudeText(string txt)
    {
        longitude_text.text = txt;
    }  
    public void UpdateAltitudeText(string txt)
    {
        altiitude_text.text = txt;
    }  
    public void UpdateEpochText(string txt)
    {
        epoch_text.text = txt;
    }

}