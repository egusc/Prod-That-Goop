using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    int goopCount = 0;
    CurrencyText currencyText;

    private void Awake() {
        currencyText = FindObjectOfType<CurrencyText>();
        currencyText.UpdateText(goopCount.ToString());
    }

    public int GoopCount
    {
        get
        {
                return goopCount;
        }
    }
    public void IncreaseGoop(int value, int mulitiplier = 1)
    {
        goopCount += value * mulitiplier;
        currencyText.UpdateText(goopCount.ToString());
    }
}
