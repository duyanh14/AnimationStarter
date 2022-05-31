using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public Button openPopupBtn;
    private Animator openPopupBtnAnimator;

    void Start()
    {
        openPopupBtnAnimator = openPopupBtn.GetComponent<Animator>();
        openPopupBtn.onClick.AddListener(openPopup);
    }

    private void openPopup()
    {
        openPopupBtnAnimator.SetTrigger("Disabled");
    }

    public void closePopup()
    {
        openPopupBtnAnimator.SetTrigger("Normal");
    }

    void Update()
    {
    }
}