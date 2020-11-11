using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Slot : MonoBehaviour
{
    public Material material;
    public TextMeshProUGUI textMoney;
    public Transform shopPos;

    private Money money;
    private Image _image;

    void Awake()
    {
        _image = GetComponent<Image>();
        money = FindObjectOfType<Money>();
    }

    void Start()
    {
        if(material != null )
            _image.sprite = material._spriteRenderer.sprite;
    }

    public void TryBuy()
    {
        if(money.moneyAmount >= material.price)
        {
            money.moneyAmount -= material.price;
            DropMaterial();
        }
    }


    void DropMaterial()
    {
        Material newMaterial = Instantiate(material, shopPos.position, Quaternion.identity);
        newMaterial._rigidbody.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
