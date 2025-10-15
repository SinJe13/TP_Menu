using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{

    public Image ImageFade;
    public List<MainMenuButton> Buttons;

    private void Start()
    {
        ImageFade.DOFade(0, 0); //alpha à 0
        ImageFade.gameObject.SetActive(false); //on le désactive pour qu'il ne bloque pas les boutons
    }

    public void OnClickPlay()
    {
        for (int i = 1; i < Buttons.Count; i++)
        {
            Buttons[i].Hide(0.1f);
        }

        ImageFade.gameObject.SetActive(true);
        ImageFade.DOFade(1, 0.8f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
