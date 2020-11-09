using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PingCalculator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI pingText;

    public float delay;

    private void Start()
    {
        StartCoroutine(CalculatePing());
    }

    IEnumerator CalculatePing()
    {
        pingText.text = $"Ping : {PhotonNetwork.GetPing()}";
        yield return new WaitForSeconds(delay);
        StartCoroutine(CalculatePing());
    }
}
