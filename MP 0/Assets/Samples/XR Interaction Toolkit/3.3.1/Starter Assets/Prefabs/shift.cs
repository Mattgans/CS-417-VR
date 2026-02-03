using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerZSwap : MonoBehaviour
{
    public InputActionReference action;

    public float roomZ = 0f;
    public float externalZ = -50f;

    private bool atRoom = true;

    void Start()
    {
        // Ensure action is enabled
        action.action.Enable();

        // Start at Z = 0
        SetZ(roomZ);
        atRoom = true;

        action.action.performed += (ctx) =>
        {
            SwapPosition();
        };
    }

    void SwapPosition()
    {
        if (atRoom)
        {
            SetZ(externalZ);
        }
        else
        {
            SetZ(roomZ);
        }

        atRoom = !atRoom;
    }

    void SetZ(float z)
    {
        Vector3 pos = transform.position;
        pos.z = z;
        transform.position = pos;
    }
}
