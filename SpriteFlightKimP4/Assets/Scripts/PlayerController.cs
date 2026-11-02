using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Mouse.current.leftButton.isPressed) {
            Debug.Log("Mouse was pressed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed) {
            Vector3 mousePos = Mouse.current.position.value;
            Debug.Log("Mouse was pressed");
        }
    }
}
