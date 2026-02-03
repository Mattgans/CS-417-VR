using UnityEngine;

public class moon : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,20 * Time.deltaTime,0);
    }
}
