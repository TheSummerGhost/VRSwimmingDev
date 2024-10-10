using UnityEngine;
using UnityEngine.InputSystem;

public class VRMovement : MonoBehaviour
{
    [SerializeField] private VRHand leftHand;
    [SerializeField] private VRHand rightHand;

    





































































    // public InputActionReference grabAction;
    //
    // public Transform handTransform;
    // public Transform rigTransform;
    //
    // public Rigidbody rigRigidbody;
    //
    // private bool isGrabbing = false;
    //
    // private Vector3 initialLocalHandPosition;
    // private Vector3 initialRigPosition;
    // private Vector3 lastHandPosition;
    // private Vector3 lingeringVelocity;
    //
    // public float grabMult = 2f;
    // public float velocityLingerFactor = 0.2f;
    // public float velocityMult = 2f;
    // public float grabAcceleration = 5f;
    //
    // private float grabAccellLerp = 0f;
    //
    // void Start()
    // {
    //     rigRigidbody = rigTransform.GetComponent<Rigidbody>();
    // }
    //
    // void Update()
    // {
    //     HandleGrabMovement();
    // }
    //
    // void HandleGrabMovement()
    // {
    //     if (grabAction.action.ReadValue<float>() == 1f)
    //     {
    //         if (!isGrabbing) 
    //         {
    //             
    //             initialLocalHandPosition = rigTransform.InverseTransformPoint(handTransform.position);
    //             initialRigPosition = rigTransform.position;
    //             lastHandPosition = handTransform.position;
    //             isGrabbing = true;
    //             rigRigidbody.isKinematic = true;
    //             
    //             grabAccellLerp = 0f;
    //         }
    //         else
    //         {
    //             
    //             Vector3 currentLocalHandPosition = rigTransform.InverseTransformPoint(handTransform.position);
    //             
    //             
    //             Vector3 handOffset = initialLocalHandPosition - currentLocalHandPosition;
    //             
    //             handOffset *= grabMult;
    //             
    //             handOffset += lingeringVelocity * (velocityLingerFactor * Time.deltaTime);
    //             
    //             grabAccellLerp += grabAcceleration * Time.deltaTime;
    //             grabAccellLerp = Mathf.Clamp01(grabAccellLerp);
    //             
    //             
    //             // rigTransform.position = initialRigPosition + handOffset;
    //
    //             rigTransform.position = Vector3.Lerp(initialRigPosition,  initialRigPosition + handOffset, grabAccellLerp);
    //             
    //             lastHandPosition = handTransform.position;
    //         }
    //     }
    //     else if (isGrabbing)
    //     {
    //         
    //         Vector3 handVelocity = (handTransform.position - lastHandPosition) / Time.deltaTime;
    //         
    //         Vector3 reversedHandVelocity = new (handVelocity.x * -1, handVelocity.y * -1, handVelocity.z * -1);
    //         
    //         reversedHandVelocity *= velocityMult;
    //         
    //         rigRigidbody.isKinematic = false;
    //         rigRigidbody.AddForce(reversedHandVelocity * rigRigidbody.mass, ForceMode.VelocityChange);
    //
    //         isGrabbing = false;
    //     }
    // }
}
