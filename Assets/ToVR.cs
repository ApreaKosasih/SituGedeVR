﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ToVR : MonoBehaviour
{
    
    public void Start()
    {
        StartCoroutine(SwitchToVR("cardboard"));
    }

    public IEnumerator SwitchToVR(string YESVR)
    {
        XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        XRSettings.enabled = true;

    }
    
    //// Call via `StartCoroutine(SwitchToVR())` from your code. Or, use
    //// `yield SwitchToVR()` if calling from inside another coroutine.
    //IEnumerator SwitchToVR()
    //{
    //    // Device names are lowercase, as returned by `XRSettings.supportedDevices`.
    //    string desiredDevice = "cardboard"; // Or "daydream".

    //    // Some VR Devices do not support reloading when already active, see
    //    // https://docs.unity3d.com/ScriptReference/XR.XRSettings.LoadDeviceByName.html
    //    if (String.Compare(XRSettings.loadedDeviceName, desiredDevice, true) != 0)
    //    {
    //        XRSettings.LoadDeviceByName(desiredDevice);

    //        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
    //        yield return null;
    //    }

    //    // Now it's ok to enable VR mode.
    //    XRSettings.enabled = true;
    //}
}
