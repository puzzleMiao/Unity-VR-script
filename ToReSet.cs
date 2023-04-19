using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToReSet : MonoBehaviour
{

    [SerializeField]
    private Button ToReSetButton;





    private void Start()
    {
        ToReSetButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Reset");
            
        });
        
    }
}
