using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NetworkCanvas : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI networkMessage;
    [SerializeField]
    private Image backGround;

    private PhotonManager photonManager;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        UpdateStatus(false, "");
        photonManager = FindObjectOfType<PhotonManager>();
    }

    private void OnEnable() => photonManager.networkCanvasAction += UpdateStatus;
    

    private void OnDisable() => photonManager.networkCanvasAction -= UpdateStatus;
    

    void UpdateStatus(bool value, string message)
    {
        backGround.gameObject.SetActive(value);
        networkMessage.text = message;
    }
}
