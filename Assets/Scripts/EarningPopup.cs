using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class EarningPopup : MonoBehaviour
{

    public Slider GoldSlider;
    public DOText GoldText;

    public Slider GemSlider;
    public TMP_Text GemText;
    void Start()
    {
        transform.DOMoveX(2, 1);

        GoldTextz.DOText("465", 3f, false, ScrambleMode.Numerals, "0123456789").From("0");
    }

    void Update()
    {
        
    }
}
