using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] Currency currency;

    int multiplierCost = 100;
    int gpsCost = 20;

    [SerializeField] UIText multiplierCostText;
    [SerializeField] UIText gpsCostText;

    private void Start() {
        multiplierCostText.UpdateText(multiplierCost.ToString());
        gpsCostText.UpdateText(gpsCost.ToString());
    }

    public void UpgradeMultiplier()
    {
        if(!(currency.GoopCount >= multiplierCost))
        {
            Debug.Log("Too broke!");
            return;
        }

        currency.GoopCount = currency.GoopCount - multiplierCost;
        currency.Multiplier = currency.Multiplier + 1;
        multiplierCost = multiplierCost * 2;
        gpsCost = Mathf.Min(multiplierCost, 999999999);
        multiplierCostText.UpdateText(multiplierCost.ToString());
    }

    public void UpgradeGoopPerSecond()
    {
        if(!(currency.GoopCount >= gpsCost))
        {
            Debug.Log("Too broke!");
            return;
        }

        currency.GoopCount = currency.GoopCount - gpsCost;
        currency.GoopPerSecond = currency.GoopPerSecond + 1;
        gpsCost = gpsCost + 20;
        gpsCost = Mathf.Min(gpsCost, 999999999);
        gpsCostText.UpdateText(gpsCost.ToString()); 
    }



}
