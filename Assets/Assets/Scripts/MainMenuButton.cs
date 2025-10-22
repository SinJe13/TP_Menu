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
    private RectTransform _Rect;
    private float x;

    public void Start()
    {
        //_Rect = GetComponent<RectTransform>();
        //x = _Rect.anchoredPosition.x;
    }

    public void OnPointEnter()
    {
        if (_hidden)
            return;

        //_Rect.DOKill();
        //_Rect.DOAnchorPosX(x + 50f, 0.5f);
        ImageOutline.DOKill();
        ImageOutline.DOFade(1, 0.3f);
        UITextMeshPro.DOKill();
        UITextMeshPro.DOColor(OverColor, 0.3f);
    }

    public void OnPointExit()
    {
        if (_hidden)
            return;

        //_Rect.DOKill();
        //_Rect.DOAnchorPosX(x, 0.5f);
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