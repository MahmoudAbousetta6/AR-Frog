using System.Collections;
using UnityEngine;

public class RotateObject : ObjectsTransformBase
{
    [SerializeField] private Transform objectToRotate;
    [SerializeField] private float rotationSpeed = 0.8f;

    private Coroutine coroutine;
    private Vector2 rotationDirection;

    private void Start()
    {
        touchControls.Rotate.SecondaryTouchDetect.started += _ => StartRotateGameObject();
        touchControls.Rotate.SecondaryTouchDetect.canceled += _ => EndRotateGameObject();
    }

    private void StartRotateGameObject()
    {
        coroutine = StartCoroutine(RotateGameObject());
        TransformEvent.Invoke(true);
    }

    private void EndRotateGameObject()
    {
        StopCoroutine(coroutine);
        rotationDirection = Vector2.zero;
        TransformEvent.Invoke(false);
    }

    public override void StartTouch()
    {
        touchControls.Rotate.Enable();
    }

    public override void StopTouch()
    {
        touchControls.Rotate.Disable();
    }

    private IEnumerator RotateGameObject()
    {
        rotationDirection.x = 0;
        rotationDirection = touchControls.Rotate.PrimaryFingerPosition.ReadValue<Vector2>();

        while (true)
        {
            yield return null;
            if (!IsWorking) continue;
            rotationDirection.y = 0;
            var _tempRotationDirection = touchControls.Rotate.PrimaryFingerPosition.ReadValue<Vector2>();

            if ((_tempRotationDirection.x - rotationDirection.x) >= 0.1f)
                objectToRotate.Rotate(-Vector3.up * rotationDirection.x * rotationSpeed * Time.deltaTime);
            else if ((_tempRotationDirection.x - rotationDirection.x) <= -0.1)
                objectToRotate.Rotate(Vector3.up * rotationDirection.x * rotationSpeed * Time.deltaTime);

            rotationDirection = _tempRotationDirection;
        }
    }
}