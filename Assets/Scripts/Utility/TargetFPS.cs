using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFPS : MonoBehaviour
{
    [Range(15, 90)] [SerializeField] private int fps;

    private void Start()
    {
        Application.targetFrameRate = fps;
    }
}