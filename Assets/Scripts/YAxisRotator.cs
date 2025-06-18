using UnityEngine;

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