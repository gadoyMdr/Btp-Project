using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour, IActionWhenInteractedWith
{
    public Action<GameObject, bool> ActionTriggerd { get; set; }

    [SerializeField]
    private List<Material> materialToSell = new List<Material>();

    [SerializeField]
    private Transform spawnTransform;

    [SerializeField]
    private Slot slotPrefab;

    [SerializeField]
    private Canvas shopCanvas;

    [SerializeField]
    private Transform slotsContent;

    public TextMeshProUGUI textMoney;

    private PlayerMoney playerMoney;

    private void Awake()
    {
        playerMoney = FindObjectOfType<PlayerMoney>();
    }

    void Start()
    {
        CloseShop();
        InitiateShop();
    }

    private void OnEnable() => Slot.BuyRequest += TryBuy;
    
    private void OnDisable() => Slot.BuyRequest -= TryBuy;

    public void OpenShop() 
    {
        shopCanvas.gameObject.SetActive(true);
        StaticVariables.IsAnyUIOn = true;
    }

    public void CloseShop()
    {
        shopCanvas.gameObject.SetActive(false);
        StaticVariables.IsAnyUIOn = false;
    }

    void InitiateShop() => materialToSell.ForEach(x => Instantiate(slotPrefab, slotsContent).SetParameters(x));
    

    public void TryBuy(Material material)
    {
        if (playerMoney.moneyAmount >= material.price)
        {
            playerMoney.moneyAmount -= material.price;
            DropMaterial(material);
        }
    }


    void DropMaterial(Material material)
    {
        Material newMaterial = Instantiate(material, spawnTransform.position, Quaternion.identity, GameObject.Find("Materials").transform);
        newMaterial._rigidbody.AddForce(Vector2.one * 3, ForceMode2D.Impulse);
    }

    public void TriggerAction(object[] parameters) 
    {
        OpenShop();
        ActionTriggerd?.Invoke(gameObject, true);
    }



    public void TurnOffAction()
    {
        CloseShop();
        ActionTriggerd?.Invoke(gameObject, false);
    }
}
