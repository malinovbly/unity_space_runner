using UnityEngine;

public class StarRotation : MonoBehaviour
{
    [SerializeField] int _rotationSpeedX;
    [SerializeField] int _rotationSpeedY;
    [SerializeField] int _rotationSpeedZ;

    void Update()
    {
        float speedX = _rotationSpeedX * Time.deltaTime;
        float speedY = _rotationSpeedY * Time.deltaTime;
        float speedZ = _rotationSpeedZ * Time.deltaTime;

        gameObject.transform.localEulerAngles += new Vector3(speedX, speedY, speedZ);
    }
}
