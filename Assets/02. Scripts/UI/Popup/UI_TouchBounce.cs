using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class UI_TouchBounce : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float EndScale = 0.9f;
    public float StartScale = 1f;
    public float Duration = 0.2f;

    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        StartScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.DOScale(EndScale, Duration).SetEase(Ease.InOutBounce).OnComplete(() => transform.localScale = Vector3.one * EndScale).SetUpdate(true);
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        transform.DOScale(StartScale, Duration).SetEase(Ease.InOutBounce).OnComplete(() => transform.localScale = Vector3.one * StartScale).SetUpdate(true);
    }
}