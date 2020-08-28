using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceDemo : MonoBehaviour
{

    private string cubeName = "Cube";

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    void OnJoinedLobby()
    {
        RoomOptions options = new RoomOptions()
        {
            isVisible = false,
            maxPlayers = 4
        };
        PhotonNetwork.JoinOrCreateRoom("room", options, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(
            cubeName,
            Vector3.zero,
            Quaternion.identity,
            0
        );
    }

}