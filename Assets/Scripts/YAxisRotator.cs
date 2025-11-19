using System;
using UnityEngine;

[Obsolete("This component is deprecated. Use DOTween.YAxisRotator instead.", true)]
public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float _speed = 250f;

    private void Update()
    {
        RotateOnYAxis();
    }

    private void RotateOnYAxis()
    {
        transform.Rotate(Vector3.up * (_speed * Time.deltaTime));
    }
}