using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateRoomUIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField roomNameInput;

    [SerializeField]
    private Slider sliderPlayerAmount;

    private PhotonManager photonManager;

    private void Awake()
    {
        photonManager = FindObjectOfType<PhotonManager>();
    }

    public void OnValueChanged() => CheckInputs();

    public void GoMultiplayerScene() => SceneManager.LoadScene("MultiplayerScene");
    

    public void CreateRoom()
    {
        photonManager?.CreateRoom(
            roomNameInput.text,
            new RoomOptions
            {
                CustomRoomProperties = new ExitGames.Client.Photon.Hashtable
                {
                    { CustomProperties.playerHost.propertyName, PhotonNetwork.NickName }
                },
                MaxPlayers = (byte)sliderPlayerAmount.value,
                IsVisible = true,
                IsOpen = true
            }
        );
    }

    //Will do later
    void CheckInputs()
    {

    }
}
