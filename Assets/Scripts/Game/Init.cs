using Steamworks;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _serverGO;
    [SerializeField] private GameObject _clientGO;
    void Start()
    {
      if(SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null)
        {
            Console.WriteLine("Server Build");
            Instantiate(_serverGO);
        
        }
      else
        {
            Debug.Log("Client Build");
            Instantiate(_clientGO);
            SceneManager.LoadSceneAsync("MainMenu");
        }

        Destroy(gameObject);
    }

}
