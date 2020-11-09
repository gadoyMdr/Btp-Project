using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneLogic : MonoBehaviour
{
    [SerializeField]
    private Transform playerSpawnPoint;

    private void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        GameObject playerPrefab = PhotonNetwork.Instantiate(
            "Prefabs/Player",
            playerSpawnPoint.position,
            Quaternion.identity);

        FindObjectOfType<ControlManager>().SetPlayer(playerPrefab.GetComponent<Player>());
    }
}
