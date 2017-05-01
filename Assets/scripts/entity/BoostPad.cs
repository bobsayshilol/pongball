using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Lights up when a ball triggers it
/// </summary>
public class BoostPad : MonoBehaviour
{

    public Color baseColor;
    public Color lightColor;
    public float fadeDuration;

    void Start()
    {
        SetColor(baseColor);
    }

    public void lightEnabled()
    {
        SetColor(lightColor);
    }

    public void lightDisabled()
    {
        SetColor(baseColor);
    }

    Color GetColor()
    {
        return GetComponent<Renderer>().material.color;
    }

    void SetColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
        GetComponent<Renderer>().material.SetColor("_EmissionColor", color);
    }
}
