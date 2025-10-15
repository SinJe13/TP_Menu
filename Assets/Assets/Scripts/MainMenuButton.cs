using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    public Image ImageOutline;
    public TMP_Text UITextMeshPro;
    public Color InitialColor, OverColor;
    private bool _hidden = false;

    public void OnPointEnter()
    {
        if (_hidden)
            return;

        ImageOutline.DOKill();
        ImageOutline.DOFade(1, 0.3f);
        UITextMeshPro.DOKill();
        UITextMeshPro.DOColor(OverColor, 0.3f);
    }

    public void OnPointExit()
    {
        if (_hidden)
            return;

        ImageOutline.DOKill();
        ImageOutline.DOFade(0.3f, 0.2f);
        UITextMeshPro.DOKill();
        UITextMeshPro.DOColor(OverColor, 0.2f);
    }

    public void Hide(float time)
    {
        ImageOutline.DOKill();
        ImageOutline.DOFade(0, time);

        UITextMeshPro.DOKill();
        UITextMeshPro.DOFade(0, time);

        _hidden = true;
    }
}