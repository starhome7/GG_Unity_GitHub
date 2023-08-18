using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public enum FadeState
    {
        FadeIn = 0,
        FadeOut,
        FadeEffect
    }
    private Image image;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime;

    [SerializeField]
    private AnimationCurve fadeCurve;

    public FadeState fadeState;
    public int LoopNum;

    public void Awake()
    {
        image = GetComponent<Image>();
        OnFade(fadeState);
    }

    public void OnFade(FadeState state)
    {
        switch (fadeState)
        {
            case FadeState.FadeIn:
                StartCoroutine(Fade(1, 0));
                break;
            case FadeState.FadeOut:
                StartCoroutine(Fade(0, 1));
                break;
            case FadeState.FadeEffect:
                StartCoroutine(FadeEffect());
                break;
        }
    }

    int i = 0;
    private IEnumerator FadeEffect()
    {
        while (true)
        {
            yield return StartCoroutine(Fade(0, 1));

            yield return StartCoroutine(Fade(1, 0));
            i++;
            if (fadeState == FadeState.FadeEffect && i == LoopNum)
            {
                gameObject.SetActive(false);
                break;
            }
        }
    }
    private IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            Color color = image.color;
            color.a = Mathf.Lerp(start, end, fadeCurve.Evaluate(percent));
            image.color = color;

            yield return null;
        }
        /*if (fadeState == FadeState.FadeIn || fadeState == FadeState.FadeOut)
        {
            gameObject.SetActive(false);
        }*/
    }

}
