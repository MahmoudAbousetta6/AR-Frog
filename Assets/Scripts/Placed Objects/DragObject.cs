using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class DragObject : ObjectsTransformBase
{
    private Vector2 touchPosition = default;
    private Coroutine coroutine;
    private bool isPressed;
    private float rate = 0.05f;
    private float elp = 0;
    private Vector2 lastPos;
    private float longPressDuration = 1.54f;
    public UnityEvent<bool> onLongTap;
    protected override void AddListener()
    {
        base.AddListener();
        touchControls.Drag.SecondaryTouchDetect.performed += StartDragGameObject;
        touchControls.Drag.SecondaryTouchDetect.canceled += EndDragGameObject;
    }

    protected override void RemoveListener()
    {
        base.RemoveListener();
        touchControls.Drag.SecondaryTouchDetect.performed -= StartDragGameObject;
        touchControls.Drag.SecondaryTouchDetect.canceled -= EndDragGameObject;
    }

    private void CustomUpdate()
    {
        elp += rate;
        var pos = touchControls.Drag.PrimaryFingerPosition.ReadValue<Vector2>();
        if (pos != lastPos) elp = 0;
        lastPos = pos;
        if (elp >1f)
        {
            onLongTap?.Invoke(true);
        }
        if (elp >= longPressDuration)
        {
            if (IsInvoking(nameof(CustomUpdate)))
                CancelInvoke(nameof(CustomUpdate));
            TransformEvent.Invoke(true);
            lastPos = Vector2.zero;
            elp = 0;
            onLongTap?.Invoke(false);
        }
    }

    private void StartDragGameObject(InputAction.CallbackContext ctx)
    {
        isPressed = ctx.ReadValueAsButton();

        coroutine = StartCoroutine(DragGameObject());

        lastPos = touchControls.Drag.PrimaryFingerPosition.ReadValue<Vector2>();
        if (!IsInvoking(nameof(CustomUpdate)))
        {
            elp = 0;
            InvokeRepeating(nameof(CustomUpdate), 0, rate);
        }
    }

    private void EndDragGameObject(InputAction.CallbackContext ctx)
    {
        isPressed = ctx.ReadValueAsButton();

        StopAllCoroutines();
        PlaneHandler.instance.TouchHoldTap(false);

        if (IsInvoking(nameof(CustomUpdate)))
            CancelInvoke(nameof(CustomUpdate));
        TransformEvent.Invoke(false);
        onLongTap?.Invoke(false);
    }

    public override void StartTouch()
    {
        touchControls.Drag.Enable();
        AddListener();
    }

    public override void StopTouch()
    {
        touchControls.Drag.Disable();
        RemoveListener();
    }

    private IEnumerator DragGameObject()
    {
        while (true)
        {
            yield return null;
            if (!IsWorking) continue;
            PlaneHandler.instance.TouchHoldTap(true);
        }
    }
}