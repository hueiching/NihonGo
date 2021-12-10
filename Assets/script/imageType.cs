using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class imageType : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    public Image progress;
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(video.frameCount > 0){
            progress.fillAmount = (float)video.frame / (float)video.frameCount;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(progress.rectTransform,eventData.position, null, out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localPoint.x);
            SkipToPercent(pct);
        }
    }

    public void SkipToPercent(float pct)
    {
        var frame = video.frameCount * pct;
        video.frame = (long)frame;
    }
}
