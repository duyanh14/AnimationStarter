using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public EarningPopup popup;
    
    public Button openPopupBtn;
    private Animator openPopupBtnAnimator;
    
    public Button closePopupBtn;
    
    void Start()
    {
        openPopupBtnAnimator = openPopupBtn.GetComponent<Animator>();
        openPopupBtn.onClick.AddListener(openPopup);
        closePopupBtn.onClick.AddListener(closePopup);
    }

    private void openPopup()
    {
        openPopupBtnAnimator.Play("Disabled");
        popup.gameObject.SetActive(true);
    }

    public void closePopup()
    {
        popup.gameObject.SetActive(false);
        openPopupBtnAnimator.SetTrigger("Normal");
        openPopupBtnAnimator.enabled = true;
    }
}