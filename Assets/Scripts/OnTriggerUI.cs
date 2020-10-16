using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider2D))]
public class OnTriggerUI : MonoBehaviour
{
    public float fadeInTime = 1.0f;
    public float fadeOutTime = 1.0f;
    public float fadeTransitionTime = 1.0f;
    [SerializeField] private Image m_Image;
    private IEnumerator FadeOutEnumerator = null;
    bool fadingIn = false;
    bool fadingOut = false;
    // Adds in fields.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !fadingIn)
        {
            if (!m_Image.enabled) { m_Image.enabled = true; }
            Color disposeColor = m_Image.color;
            disposeColor.a = 1;
            m_Image.CrossFadeAlpha(0.0f, 0.0f, true);
            m_Image.color = disposeColor;
            fadingIn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !fadingOut)
        {
            if (FadeOutEnumerator != null) { StopCoroutine(FadeOutEnumerator); FadeOutEnumerator = null; }
            Color disposeColor = m_Image.color;
            disposeColor.a = 1;
            m_Image.CrossFadeAlpha(1.0f, 0.0f, true);
            m_Image.color = disposeColor;
            fadingOut = true;
        }
    }

    void Update()
    {
        if (fadingIn)
        {
            m_Image.CrossFadeAlpha(1.0f, fadeInTime, false);
            if(m_Image.color.a >= 1.0f)
            {
                fadingIn = false;
                FadeOutEnumerator = FadeOutDelay();
                StartCoroutine(FadeOutEnumerator); }
        }
        else if (fadingOut)
        {
            m_Image.CrossFadeAlpha(0.0f, fadeOutTime, false);
            if(m_Image.color.a <= 0.0f) { fadingOut = false; }
        }
    }

    private IEnumerator FadeOutDelay()
    {
        yield return new WaitForSeconds(fadeTransitionTime);
        Color disposeColor = m_Image.color;
        disposeColor.a = 1;
        m_Image.CrossFadeAlpha(1.0f, 0.0f, true);
        m_Image.color = disposeColor;
        fadingOut = true;
    }

    /*void OnGUI()
    {
        //Fetch the Toggle's state
        m_Fading = GUI.Toggle(new Rect(0, 0, 100, 30), m_Fading, "Fade In/Out");
    }*/
}