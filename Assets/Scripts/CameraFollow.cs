using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0.35f, -10f);
    private float smoothTime = 0.15f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    void Update()
    {
        Vector3 targetPostition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPostition, ref velocity, smoothTime);
    }
}
