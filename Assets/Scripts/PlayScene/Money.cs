using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    private float MoneyAmount;

    public float moneyAmount
    {
        get => MoneyAmount;
        set 
        {
            MoneyAmount = value;
            UpdateTextMoney();
        }
    }

    private void UpdateTextMoney()
    {
        moneyText.text = $"Money : { moneyAmount }";
    }
    void Start()
    {
        moneyAmount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
