using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuManager : MonoBehaviourPunCallbacks
{
    public Button connectionButton;


    public void ConnectionPhoton() // nos conecta al photon despues de ingresar el nombre
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.JoinLobby();
        //PhotonNetwork.JoinOrCreateRoom();
    }

    /*public override void JoinOrCreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
    }
    */
    public void ExitButton()
    {
        Application.Quit();
    }
}
