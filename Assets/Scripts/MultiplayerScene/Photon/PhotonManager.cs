using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    //Show and hide the canvas that's responsible for showing you network state
    public Action<bool, string> networkCanvasAction;

    private void Awake() => DontDestroyOnLoad(gameObject);
    

    public void ConnectToPhoton()
    {
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
            networkCanvasAction?.Invoke(true, "Connecting To Server ...");
        }
    }

    public void CreateRoom(string roomName, RoomOptions roomOptions)
    {
        //PhotonNetwork.CreateRoom creates and makes you join the created room;
        PhotonNetwork.CreateRoom(roomName, roomOptions);
        networkCanvasAction?.Invoke(true, "Creating your room");
    }

    void CreateNewLobbyAndJoin()
    {
        //A lobby is a room of room
        PhotonNetwork.JoinLobby(new TypedLobby("Training Room", LobbyType.Default));
    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    #region CALLBACKS
    public override void OnCreatedRoom()
    {
        networkCanvasAction?.Invoke(false, "");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("PlayScene");
    }

    //When connected to Photon (cloud)
    public override void OnConnectedToMaster()
    {
        networkCanvasAction?.Invoke(false, "");
        CreateNewLobbyAndJoin();
    }

    #endregion
    

}
