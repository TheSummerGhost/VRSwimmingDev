using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRHand : MonoBehaviour
{
    public InputActionReference grabInputReference;

    public Transform handTransform;
    public Transform rigTransform;
    
    public Vector3 initialHandPosition;
    public Vector3 lastHandPosition;
    public Vector3 currentHandPosition;

    public event Action<Vector3> OnStartGrab;
    public event Action<Vector3> OnEndGrab;

    private float GrabInput => grabInputReference.action.ReadValue<float>();

    private void Start() {
        
    }

    private void Update() {
        if (GrabInput == 1) {
            StartGrab();
        }
    }
    
    void StartGrab() {
        OnStartGrab?.Invoke(rigTransform.InverseTransformPoint(handTransform.position));
    }

    void EndGrab() {
        OnEndGrab?.Invoke(rigTransform.InverseTransformPoint(handTransform.position));
    }

}

