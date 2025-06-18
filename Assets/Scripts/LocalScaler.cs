using UnityEngine;

public class LocalScaler : MonoBehaviour
{
    [SerializeField] private Vector3 _speed = new Vector3(0.1f, 0.1f, 0.1f);

    private void Update()
    {
        EnlargeScale();
    }

    private void EnlargeScale()
    {
        float enlargedLocalScaleX = transform.localScale.x * _speed.x * Time.deltaTime;
        float enlargedLocalScaleY = transform.localScale.y * _speed.y * Time.deltaTime;
        float enlargedLocalScaleZ = transform.localScale.z * _speed.z * Time.deltaTime;
        Vector3 enlargedLocalScale = new Vector3(enlargedLocalScaleX, enlargedLocalScaleY, enlargedLocalScaleZ);
        
        transform.localScale += enlargedLocalScale;
    }
}