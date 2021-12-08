using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveHandler : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer mat;
    float currentVelocity = 0.0f;
    float smoothTimer = 0.4f;

    private bool isValueReached;
    private void Update()
    {
        float currentValue = mat.material.GetFloat("_CutoffHeight");
        float newValue = Mathf.SmoothDamp(mat.material.GetFloat("_CutoffHeight"), 1.2f, ref currentVelocity, smoothTimer);

        if (!isValueReached)
        {
            mat.material.SetFloat("_CutoffHeight", newValue);

            if (currentValue == newValue)
                isValueReached = true;
        }
        else if (isValueReached) return;
    }
}