using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
