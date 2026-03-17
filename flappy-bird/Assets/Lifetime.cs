using System;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public bool IsRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsRunning = false;
    }

    public void EnableRuntime() { IsRunning = true; }
}
