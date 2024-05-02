using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

public enum KEY
{
    A,
    B,
    X,
    Y,
}

[Serializable]
public struct KeyBind
{
    public InputDeviceCommand code;
    public Sprite sprite;
}

[CreateAssetMenu(menuName ="bind")]
public class ButtonBinderData : ScriptableObject
{
    public List<KeyBind> keys;

    //public Sprite GetKey(KEY code)
    //{

    //    return keys.Find(x => x.code == code).sprite;
    //}
}
