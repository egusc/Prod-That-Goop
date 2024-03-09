using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyText : MonoBehaviour
{
    TMP_Text text;

    private void Awake() {
        text = this.GetComponent<TMP_Text>();   
    }

    public void UpdateText(string newText)
    {
        text.SetText(newText);
    }
}
