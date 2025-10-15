using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Image ImageFade;

    private void Start()
    {
        ImageFade.DOFade(0, 0); //alpha � 0
        ImageFade.gameObject.SetActive(false); //on le d�sactive pour qu'il ne bloque pas les boutons
    }

    public void OnClickPlay()
    {
        ImageFade.gameObject.SetActive(true);
        ImageFade.DOFade(1, 0.8f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
