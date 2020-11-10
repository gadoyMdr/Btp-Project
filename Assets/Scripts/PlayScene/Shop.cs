using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    private Canvas shopCanvas;
    void Start()
    {
        CloseShop();
    }
    public void OpenShop() => shopCanvas.gameObject.SetActive(true);

    public void CloseShop() => shopCanvas.gameObject.SetActive(false);

}
