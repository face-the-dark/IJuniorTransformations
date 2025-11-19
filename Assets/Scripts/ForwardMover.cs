using System;
using UnityEngine;

[Obsolete("This component is deprecated. Use DOTween.ForwardMover instead.", true)]
public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * (_speed * Time.deltaTime));
    }
}
