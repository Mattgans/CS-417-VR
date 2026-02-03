using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light lightSource;
    public InputActionReference action;   // Assign left-hand button action here

    void Start()
    {
        if (lightSource == null)
            lightSource = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += OnPressed;
    }

    void OnPressed(InputAction.CallbackContext ctx)
    {
        if (lightSource.color == Color.white)
            lightSource.color = Color.red;
        else
            lightSource.color = Color.white;
    }
}
