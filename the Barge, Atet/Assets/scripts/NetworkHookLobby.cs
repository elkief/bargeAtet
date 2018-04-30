using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype.NetworkLobby;
using UnityEngine.Networking;

public class NetworkHookLobby : LobbyHook {

    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager,
        GameObject lobbyPlayer, GameObject gamePlayer)
    {
        LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();
        NetworkControlPlayer localPlayer = gamePlayer.GetComponent<NetworkControlPlayer>();

        localPlayer.playerName = lobby.playerName;
        localPlayer.playerColor = lobby.playerColor;
    }
}