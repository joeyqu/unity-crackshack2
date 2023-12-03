using Game.Model;
using UnityEngine;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using GameServices;

public class ClientNetworkManager : NetworkManager
{
    // Start is called before the first frame update
    async void Start()
    {
        UnityTransport transport = gameObject.AddComponent<UnityTransport>();
        NetworkConfig.NetworkTransport = transport;

        Player player = await PlayerService.GetPlayer("steam_id");
        Debug.Log(player.Gamertag);
        Debug.Log($"Player retrieved: {player.Gamertag}");

        StartClient();
        Debug.Log("Client Ready");
    }

    
}
