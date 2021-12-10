using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ScrollRectExtensions
{
    

    public static float GetValue(this ScrollRect scrollRect, float value)
    {
        return scrollRect.horizontal ? scrollRect.horizontalNormalizedPosition : scrollRect.verticalNormalizedPosition; 
    }

    public static void SetValue(this ScrollRect scrollRect, float value)
    {
        if(scrollRect.horizontal){
            scrollRect.horizontalNormalizedPosition = value;
        }
        else{
            scrollRect.verticalNormalizedPosition = value;
        }
    }


    
}
