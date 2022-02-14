using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveResults : MonoBehaviour
{
    private string nickName;
    //private List<int> playersScores;
    public int finishKills = 0;
    private int playersCount;
    [SerializeField] private InputField inputField;

    public void Save()
    {
        nickName = inputField.text;

        //for (int i = 1; i < playersCount + 1; i++)
        //{
        //    playersScores.Add(PlayerPrefs.GetInt($"Player{i}Score"));
        //}

        PlayerPrefs.SetInt("Player1Score", finishKills);
        PlayerPrefs.SetString("Player1Nick", nickName);

        //else
        //{
        //    for (int i = playersScores.Count; i > 0; i--)
        //    {
        //        if (kills > playersScores[i-1] && kills <= playersScores[i - 2] && i != 0)
        //        {
        //            PlayerPrefs.SetInt($"Player{i}Score", kills);
        //            PlayerPrefs.SetString($"Player{i}Nick", nickName);
        //        }
        //        //Debug.Log("Working");
        //    }
        //}

        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetInt("Player1Score"));
        Debug.Log(PlayerPrefs.GetString("Player1Nick"));
    }

    //public void PrintScores()
    //{
    //    for (int i = 1; i < playersScores.Count + 1; i++)
    //    {
    //        Debug.Log(PlayerPrefs.GetInt($"Player{i}Score"));
    //        Debug.Log(PlayerPrefs.GetString($"Player{i}Nick"));
    //    }
    //}
}
