using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace GameServices
{
    public class ServerRequest 
    {
        public static async Task<string> GetRequest(string url)
        {
            using(UnityWebRequest request = UnityWebRequest.Get(url))
            {
                await request.SendWebRequest();
                if(request.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.LogError("Could not connect to backend services");
                    return null;
                }
                else
                {
                    return request.downloadHandler.text;
                }
            }
        }
    }
}