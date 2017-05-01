using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPadOperator : MonoBehaviour
{
    public bool directionIsForward;
    public GameObject boostPad;

    public void MoveBoostPadForward()
    {
        var target = Quaternion.Euler(0, 0, 0);
        // Dampen towards the target rotation
        transform.localRotation = target;
    }

    public void MoveBoostPadBackward()
    {
        var target1 = Quaternion.Euler(0, 180, 0);
        // Dampen towards the target rotation
        transform.localRotation = target1;
    }
}