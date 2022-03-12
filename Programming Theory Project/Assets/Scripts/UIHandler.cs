using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Text playerNameText;

    public void StartNew()
    {
        MainManager.Instance.playerName = playerNameText.text;
        SceneManager.LoadScene(1);
    }
}
