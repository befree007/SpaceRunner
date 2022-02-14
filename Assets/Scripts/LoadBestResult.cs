using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBestResult : MonoBehaviour
{
    public Text textBestResult;
    
    public void Start()
    {
        if (PlayerPrefs.GetInt("Player1Score") != 0)
        {
            textBestResult.text = $"{PlayerPrefs.GetString("Player1Nick")} - {PlayerPrefs.GetInt("Player1Score")}";
        }        
    }
}
