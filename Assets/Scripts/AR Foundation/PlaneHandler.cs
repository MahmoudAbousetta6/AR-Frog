using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


[RequireComponent(typeof(ARRaycastManager))]
public class PlaneHandler : MonoBehaviour
{
    public static PlaneHandler instance;

    [SerializeField] private Camera arCamera;
    [SerializeField] private List<ObjectsTransformHandler> ObjectsToPlace;

    protected TouchControls touchControls;
    
    private ObjectsTransformHandler objectTransformHandler;
    private ARRaycastManager arRaycastManager;
    
    private int objectsToPlaceIndex;
    private float defaultRotation = 0;
    private bool onTouchHold = false;

    private static List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    public Camera ArCamera { get => arCamera; set => arCamera = value; }

    void Awake()
    {
        instance ??= this;

        touchControls = new TouchControls();
        objectsToPlaceIndex = 0;
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    private void OnEnable()
    {
        TouchSimulation.Enable();

        touchControls.SingleTap.Enable();
        touchControls.SingleTap.Tap.performed += OnTap;
    }

    private void OnDisable()
    {
        touchControls.SingleTap.Disable();
    }

    private void OnTap(InputAction.CallbackContext callbackContext)
    {
        Vector2 _touchInput = touchControls.SingleTap.Tap.ReadValue<Vector2>();
        Ray _ray = ArCamera.ScreenPointToRay(_touchInput);
        RaycastHit _hitObject;

        if (arRaycastManager.Raycast(_touchInput, _hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = _hits[0].pose;

            if (objectTransformHandler == null)
            {
                if (defaultRotation > 0)
                {
                    objectTransformHandler = Instantiate(ObjectsToPlace[objectsToPlaceIndex], hitPose.position, Quaternion.identity);
                    objectTransformHandler.transform.Rotate(Vector3.up, defaultRotation);
                }
                else
                    objectTransformHandler = Instantiate(ObjectsToPlace[objectsToPlaceIndex], hitPose.position, hitPose.rotation);

                objectTransformHandler.SelectObject();
            }
        }
    }

    public void SetObjectToPlaceIndex(int _index)
    {
        bool _validIndex = _index >= 0 && _index < ObjectsToPlace.Count;
        objectsToPlaceIndex = _validIndex ? _index : 0;
    }

    public void TouchHoldTap(bool _touchHold)
    {
        onTouchHold = _touchHold;

        Vector2 _touchInput = touchControls.SingleTap.Tap.ReadValue<Vector2>();
        if (arRaycastManager.Raycast(_touchInput, _hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            Pose _hitPose = _hits[0].pose;
            if (onTouchHold)
            {
                objectTransformHandler.transform.position = _hitPose.position;
                if (defaultRotation == 0)
                    objectTransformHandler.transform.rotation = _hitPose.rotation;
            }
        }
    }
}