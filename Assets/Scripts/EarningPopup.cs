using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class EarningPopup : MonoBehaviour
{

    public Slider goldSlider;
    public Text goldText;

    public Slider gemSlider;
    public Text gemText;

    private int goldValue = 0;
    private int gemValue = 0;
    
    void Start()
    {
        goldSlider.onValueChanged.AddListener (goldSliderChange);
        gemSlider.onValueChanged.AddListener (gemSliderChange);
        
        Random rnd = new Random();
        goldSlider.value = rnd.Next(1000, 6000);
        gemSlider.value = rnd.Next(20, 100);
    }

    public void goldSliderChange(float value)
    {
        goldText.DOText(Math.Round(value).ToString(), 2f, false, ScrambleMode.Numerals, "0").From(goldValue.ToString());
        goldValue = (int) Math.Round(value);
    }

    public void gemSliderChange(float value)
    {
        gemText.DOText(Math.Round(value).ToString(), 2f, false, ScrambleMode.Numerals, "0").From(gemValue.ToString());
        gemValue = (int) Math.Round(value);
    }
    
    void Update()
    {
        
    }
}
