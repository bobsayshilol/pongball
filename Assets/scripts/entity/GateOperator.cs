using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOperator : MonoBehaviour
{
    public bool directionIsForward;
    public GameObject gate;
    public float forwardAngle = 245.0F;
    public float restingPosition = 0.0F;
    public float backwardAngle = -245.0F;
    public float smoothMovement = 10.0F;

    private void OnEnable()
    {
        ObstacleManager.OnResetFromHost += MoveGateResting;
    }

    private void OnDisable()
    {
        ObstacleManager.OnResetFromHost -= MoveGateResting;
    }

    public void MoveGateForward()
    {
        var target = Quaternion.Euler(0, forwardAngle, 0);
        // Dampen towards the target rotation
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target,
            Time.deltaTime * smoothMovement);
    }

    public void MoveGateBackward()
    {
        var target1 = Quaternion.Euler(0, backwardAngle, 0);
        // Dampen towards the target rotation
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target1,
            Time.deltaTime * smoothMovement);
    }

    public void MoveGateResting()
    {
        //var target1 = Quaternion.Euler(0, restingPosition, 0);
        //// Dampen towards the target rotation
        //transform.localRotation = Quaternion.Slerp(transform.localRotation, target1,
        //    Time.deltaTime * smoothMovement);
        transform.localEulerAngles = new Vector3(0, 180, 0);
    }
}
