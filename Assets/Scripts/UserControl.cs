using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserControl : MonoBehaviour
{
    public Camera GameCamera;
    public Text displayText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplayName();
        }
    }

    // ABSTRACTION
    void DisplayName()
    {
        Ray ray = GameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //string cubeName = hit.collider.gameObject.name;
            string cubeName = hit.collider.GetComponent<BaseCube>().cubeName;
            displayText.text = $"{MainManager.Instance.playerName} clicked {cubeName}.";
        }
    }
}
