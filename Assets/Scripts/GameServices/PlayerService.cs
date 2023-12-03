using Game.Model;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace GameServices
{

    public class PlayerService
    {
       static private string BASE_URL = "http://localhost:5000";
        static private string GET_PLAYER = BASE_URL + "/player/{0}";
       public static async Task<Player> GetPlayer(string id)
        {
            string response = await ServerRequest.GetRequest(string.Format(GET_PLAYER, id));
            // be careful using JsonUtility as the property on the class has to match the json property name
            Player player = JsonUtility.FromJson<Player>(response);
            Debug.Log(player);
            Debug.Log(response);
            return player;
        }
    }

}
