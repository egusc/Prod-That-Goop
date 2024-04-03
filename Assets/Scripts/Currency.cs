using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using UnityEngine;

public class Currency : MonoBehaviour
{
    int goopCount = 0;
    
    [SerializeField]
    [Min(1)]
    int mulitiplier = 1;

    [SerializeField]
    [Min(0)]
    int goopPerSecond = 0;

    [SerializeField] UIText currencyText;
    [SerializeField] UIText multiplierText;
    [SerializeField] UIText goopPerSecondText;


    private void Awake() {
        currencyText.UpdateText(goopCount.ToString());
        multiplierText.UpdateText(mulitiplier.ToString());
        goopPerSecondText.UpdateText(goopPerSecond.ToString());

        InvokeRepeating("IncreaseGoopPerSecond", 2f, 1f);
    }

    public int GoopCount
    {
        get
        {
                return goopCount;
        }
    }

    public void IncreaseGoop()
    {
        goopCount += 1 * mulitiplier;
        currencyText.UpdateText(goopCount.ToString());
    }

    private void IncreaseGoopPerSecond()
    {
        goopCount += goopPerSecond;
        currencyText.UpdateText(goopCount.ToString());
    }
}
