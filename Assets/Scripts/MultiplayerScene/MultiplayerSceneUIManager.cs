using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerSceneUIManager : MonoBehaviour
{
    [SerializeField]
    private Transform roomListingsContent;

    [SerializeField]
    private RoomListing roomListing;

    public void GoCreateRoom() => SceneManager.LoadScene("CreateRoomScene");
    
    public void UpdateRoomListings(List<RoomInfo> roomList)
    {
        DestroyRoomListings();

        foreach (RoomInfo roomInfo in roomList)
            Instantiate(roomListing, roomListingsContent).SetInfos(roomInfo);
    }

    void DestroyRoomListings() { foreach (Transform t in roomListingsContent.transform) Destroy(t.gameObject); }
    
}
