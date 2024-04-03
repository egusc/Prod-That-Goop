using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Reflection.Emit;

public class UIText : MonoBehaviour
{
    TMP_Text text;
    [SerializeField] string label = "";

    private void Awake() {
        text = this.GetComponent<TMP_Text>();   
    }

    public void UpdateText(string newText)
    {
        text.SetText(label + newText);
    }
}
