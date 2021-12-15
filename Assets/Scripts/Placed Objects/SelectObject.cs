using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class SelectObject : ObjectsTransformBase
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;
    [SerializeField] private Collider collider;
    [SerializeField] private ModelOutline outline;
    private bool isSelected;
    private void OnEnable()
    {
        TouchSimulation.Enable();
        touchControls.SingleTap.Enable();
        touchControls.SingleTap.Tap.performed += StartSelectingGameObject;
        touchControls.SingleTap.Tap.canceled += EndSelectingGameObject;
        IsWorking = true;
        isSelected = false;
    }

    private void OnDisable()
    {
        touchControls.SingleTap.Disable();
    }

    private void StartSelectingGameObject(InputAction.CallbackContext ctx)
    {

        Vector2 tapPosition = ctx.ReadValue<Vector2>();
        var ray = PlaneHandler.instance.ArCamera.ScreenPointToRay(tapPosition);
        RaycastHit hit;
        IsWorking = (Physics.Raycast(ray, out hit, Mathf.Infinity));
        if (IsWorking) {


            if (hit.collider.gameObject == collider.gameObject && !isSelected)
            {
                isSelected = true;
                audioSource.Play();
                animator.SetTrigger("Attack");
                outline.enabled = true;
            }
           
        }
        else
        {
            isSelected = false;
            outline.enabled = false;
        }
        TransformEvent?.Invoke(isSelected);
    }

    private void EndSelectingGameObject(InputAction.CallbackContext ctx)
    {
        touchControls.SingleTap.Disable();
    }

    public override void StartTouch()
    {
        touchControls.SingleTap.Enable();
    }

    public override void StopTouch()
    {
        touchControls.SingleTap.Disable();
    }
}