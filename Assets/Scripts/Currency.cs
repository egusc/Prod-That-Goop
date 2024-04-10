using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using UnityEngine;

public class Currency : MonoBehaviour
{
    int goopCount = 0;
    
    [Min(1)]
    int multiplier = 1;

    [Min(0)]
    int goopPerSecond = 0;

    [SerializeField] UIText currencyText;
    [SerializeField] UIText multiplierText;
    [SerializeField] UIText goopPerSecondText;


    private void Start() {
        currencyText.UpdateText(goopCount.ToString());
        multiplierText.UpdateText(multiplier.ToString());
        goopPerSecondText.UpdateText(goopPerSecond.ToString());

        InvokeRepeating("IncreaseGoopPerSecond", 2f, 1f);
    }

    public int GoopCount
    {
        get
        {
                return goopCount;
        }
        set
        {
            goopCount = value;
            goopCount = Mathf.Min(goopCount, 999999999);
            currencyText.UpdateText(goopCount.ToString());
        }
    }

    public int Multiplier
    {
        get
        {
                return multiplier;
        }
        set
        {
            multiplier = value;
            multiplier = Mathf.Min(multiplier, 999999999);
            multiplierText.UpdateText(multiplier.ToString());
        }
    }

    public int GoopPerSecond
    {
        get
        {
                 
                return goopPerSecond;
        }
        set
        {
            goopPerSecond = value;
            goopPerSecond = Mathf.Min(goopPerSecond, 999999999);
            goopPerSecondText.UpdateText(goopPerSecond.ToString());
        }
    }

    public void IncreaseGoop()
    {
        GoopCount += 1 * Multiplier;
        currencyText.UpdateText(goopCount.ToString());
    }

    private void IncreaseGoopPerSecond()
    {
        GoopCount += GoopPerSecond;
        currencyText.UpdateText(goopCount.ToString());
    }
}
