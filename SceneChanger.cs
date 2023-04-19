using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string Maintanence; // The name of the scene to change to

    public void ChangeScene()
    {
        SceneManager.LoadScene(Maintanence);
    }
}