using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToMainMnue : MonoBehaviour
{

    [SerializeField]
    private Button GoBackMuneButton;





    private void Start()
    {
        GoBackMuneButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("NewMainMenu");
            
        });
        
    }
}
