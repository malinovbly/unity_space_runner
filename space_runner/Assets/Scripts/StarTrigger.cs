using UnityEngine;

public class StarTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            Destroy(gameObject);
        }
    }
}
