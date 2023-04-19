using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartVRButton : MonoBehaviour
{

    [SerializeField]
    private Button startVRButton;





    private void Start()
    {
        startVRButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Resident");
            
        });
        
    }
}
