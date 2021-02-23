using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamera;
    // Start is called before the first frame update

    private void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera").transform;
    }

    void LateUpdate()
    {
        // billboard the healthbar
        transform.LookAt(transform.position + playerCamera.forward);
    }
}
