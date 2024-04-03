using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGoop : MonoBehaviour
{
    Currency currencyObject;
    private void Awake() {
        currencyObject = FindObjectOfType<Currency>();
    }

    void OnMouseDown() 
    {
        currencyObject.IncreaseGoop();
    }
}
