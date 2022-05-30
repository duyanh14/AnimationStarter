using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EarningPopup : MonoBehaviour
{

    public Slider GoldSlider;
    public Text GoldText;

    public Slider GemSlider;
    public Text GemText;
    void Start()
    {
        GoldText.DOText("465", 3f, false, ScrambleMode.Numerals, "0").From("0");
        GemText.DOText("465", 3f, false, ScrambleMode.Numerals, "0").From("0");
    }

    void Update()
    {
        
    }
}
