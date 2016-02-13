using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    private const string version = "v0.0.1";
    public const string roomName = "VVR";
    public string playerPrefabName = "Player";
    public Transform spawnPoint;

	void Start () {
        Debug.Log("Connect");
        PhotonNetwork.ConnectUsingSettings(version);
	}

    void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby");
        RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4 };
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom");
        PhotonNetwork.Instantiate(playerPrefabName, spawnPoint.position, spawnPoint.rotation, 0);
    }
}
