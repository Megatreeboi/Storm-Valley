using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform cameraTransform;
    public float rotationSpeed = 5f;

    private void Update()
    {
        float cameraRotationY = cameraTransform.eulerAngles.y;
        Quaternion newRotation = Quaternion.Euler(0f, cameraRotationY, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
    }
}
