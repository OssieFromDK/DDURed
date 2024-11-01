using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool fadeIn = false;
    public bool fadeOut = false;

    public float TimeToFade;

    internal void fadeInEvent(float timetofade)
    {
        TimeToFade = timetofade;
        fadeIn = true;
    }
    internal void fadeOutEvent(float timetofade)
    {
        TimeToFade = timetofade;
        fadeOut = true;
    }

    void Update()
    {
        if (fadeIn)
        {
            if(canvasGroup.alpha < 1f)
            {
                canvasGroup.alpha += TimeToFade * Time.deltaTime;

                if(canvasGroup.alpha >= 1f)
                {
                    fadeIn = false;
                }
            }
        }

        if (fadeOut)
        {
            if (canvasGroup.alpha >= 0f)
            {
                canvasGroup.alpha -= TimeToFade * Time.deltaTime;

                if (canvasGroup.alpha <= 0f)
                {
                    fadeOut = false;
                }
            }
        }
    }
}
