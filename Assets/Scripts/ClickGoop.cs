using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGoop : MonoBehaviour
{
    Currency currencyObject;
    AudioSource clickAudio;

    private void Awake() {
        currencyObject = FindObjectOfType<Currency>();
        clickAudio = GetComponentInChildren<AudioSource>();
    }

    void OnMouseDown() 
    {
        currencyObject.IncreaseGoop();
        clickAudio.Play();

        float scale = Random.Range(9.5f, 10.5f);
        this.transform.localScale = new Vector3(scale, scale, 1);
    }
}
