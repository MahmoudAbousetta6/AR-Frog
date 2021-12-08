using System.Collections;
using UnityEngine;

public class ScaleObject : ObjectsTransformBase
{
    [SerializeField] private Transform objectToScale;
    private float pinchInitialDistance;
    private Vector3 objectInitialScale;
    private Coroutine coroutine;

    private void Start()
    {
        touchControls.Scale.SecondaryTouchDetect.started += _ => StartScaleGameObject();
        touchControls.Scale.SecondaryTouchDetect.canceled += _ => EndScaleGameObject();
    }

    private void StartScaleGameObject()
    {
        coroutine = StartCoroutine(ScaleGameObject());
        TransformEvent.Invoke(true);
    }

    private void EndScaleGameObject()
    {
        StopCoroutine(coroutine);
        TransformEvent.Invoke(false);
    }

    public override void StartTouch()
    {
        touchControls.Scale.Enable();
    }

    public override void StopTouch()
    {
        touchControls.Scale.Disable();
    }

    private IEnumerator ScaleGameObject()
    {
        pinchInitialDistance = Vector2.Distance(touchControls.Scale.PrimaryFingerPosition.ReadValue<Vector2>(), touchControls.Scale.SecondaryFingerPosition.ReadValue<Vector2>());
        objectInitialScale = objectToScale.localScale;

        while (true)
        {
            yield return null;
            if (!IsWorking) continue;
            float _pinchCurrentDistance = Vector2.Distance(touchControls.Scale.PrimaryFingerPosition.ReadValue<Vector2>(), touchControls.Scale.SecondaryFingerPosition.ReadValue<Vector2>());
            float _scaleFactor = _pinchCurrentDistance / pinchInitialDistance;
            objectToScale.localScale = (objectInitialScale * _scaleFactor);
        }
    }
}