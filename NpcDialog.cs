using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class NpcDialog : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject dialogCamera;

    [SerializeField] private Transform standingPoint;
    private Transform avatar;
  
    private async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            avatar = other.transform;

            // disable player input
            avatar.GetComponent<PlayerInput>().enabled = false;

            await Task.Delay (50);

            // teleport the avatpr to standing point
            avatar.rotation = standingPoint.rotation;
            avatar.position = standingPoint.position;

            // disable main camera, activate dialog camera
            mainCamera.SetActive (false);
            dialogCamera.SetActive (true);

            // display cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }
    }

    public void recover()
    {
        mainCamera.SetActive(true);
        dialogCamera.SetActive(false);

        avatar.GetComponent<PlayerInput>().enabled = true;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}
