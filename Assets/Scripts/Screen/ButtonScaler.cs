using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = 0.1f;

    public Color hoverColor = Color.white;
    public Color defaultColor = Color.gray;

    private Image _image;
    private Vector3 defaultScale;
    private Tween _currentTween;

    private void Awake()
    {
        defaultScale = transform.localScale;
        _image = GetComponent<Image>();
        if (_image != null)
        {
            defaultColor = _image.color;
        }
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        _currentTween?.Kill();
        _currentTween = transform.DOScale(defaultScale * finalScale, scaleDuration);

        if (_image != null)
        {
            _image.DOColor(hoverColor, scaleDuration);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTween?.Kill();
        _currentTween = transform.DOScale(defaultScale, scaleDuration);

        if (_image != null)
        {
            _image.DOColor(defaultColor, scaleDuration);
        }
    }

    public void ResetColor()
    {
        if (_image != null)
        {
            _image.color = defaultColor;
        }
    }


}
