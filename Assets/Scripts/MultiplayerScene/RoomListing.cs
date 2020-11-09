using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoomListing : MonoBehaviour
{
    //Temporary, only for testing
    //TODO : rework this mess
    public TextMeshProUGUI hostNameText;
    public TextMeshProUGUI gameNameText;
    public TextMeshProUGUI playersText;

    public RoomInfo roomInfo;

    private PhotonManager photonManager;

    private void Awake()
    {
        photonManager = FindObjectOfType<PhotonManager>();
    }

    public void SetInfos(RoomInfo roomInfo)
    {
        this.roomInfo = roomInfo;
        playersText.text = $"Players : {roomInfo.PlayerCount} / {roomInfo.MaxPlayers}";
        hostNameText.text = $"Host : {roomInfo.CustomProperties[CustomProperties.playerHost.propertyName]}";
        gameNameText.text = $"Room name : {roomInfo.Name}";
    }

    public void JoinRoom()
    {
        photonManager.JoinRoom(roomInfo.Name);
    }

}
