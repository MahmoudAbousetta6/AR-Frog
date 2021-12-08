using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectsTransformBase : MonoBehaviour
{
    public bool IsWorking { get; set; }
    public UnityEvent<bool> TransformEvent;

    protected TouchControls touchControls;

    private void Awake()
    {
        touchControls = new TouchControls();
    }

    public virtual void StartTouch() => touchControls.Enable();

    public virtual void StopTouch() => touchControls.Disable();

    private void OnEnable()
    {
        StartTouch();
    }

    private void OnDisable()
    {
        StopTouch();
    }

    protected virtual void AddListener() { }

    protected virtual void RemoveListener() { }
}
