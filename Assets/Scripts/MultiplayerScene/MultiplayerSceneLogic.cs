using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(MultiplayerSceneUIManager))]
public class MultiplayerSceneLogic : MonoBehaviourPunCallbacks
{
    private PhotonManager photonManager;
    private MultiplayerSceneUIManager multiplayerUI;

    private void Awake()
    {
        photonManager = FindObjectOfType<PhotonManager>();
        multiplayerUI = GetComponent<MultiplayerSceneUIManager>();
    }

    void Start()
    {
        photonManager.ConnectToPhoton();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        multiplayerUI.UpdateRoomListings(roomList);
    }
}
