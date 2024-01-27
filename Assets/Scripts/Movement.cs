using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    // Set your target position here
    public Vector3 targetPosition;

    // Set the duration of the tween
    public float moveDuration = 2f;

    void Start()
    {
        // Call the MoveBall method when the script starts
        
    }

    void MoveBall()
    {
        // Use DOTween to tween the position of the ball
        transform.DOMove(targetPosition, moveDuration)
            .SetEase(Ease.Linear) // You can change the ease type if needed
            .OnComplete(() => Debug.Log("Movement Completed")); // Optional: Execute code when the tween is complete
    }

}
