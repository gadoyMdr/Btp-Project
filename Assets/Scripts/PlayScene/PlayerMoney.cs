using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI moneyText;

    public float MoneyAmount;

    public float moneyAmount
    {
        get => MoneyAmount;
        set 
        {
            MoneyAmount = value;
            UpdateTextMoney();
        }
    }

    private void UpdateTextMoney() => moneyText.text = $"Money : { moneyAmount }";
    

}
