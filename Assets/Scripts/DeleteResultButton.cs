using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteResultButton : MonoBehaviour
{

    public Text textBestResult;
    public void DeleteResult()
    {
        PlayerPrefs.DeleteAll();
        textBestResult.text = "";
    }
}
