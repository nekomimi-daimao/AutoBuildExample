using UnityEngine;

public class ShowState : MonoBehaviour
{
    private const PrimitiveType Type = PrimitiveType.Cube;

    private void Start()
    {
        GameObject.CreatePrimitive(Type);
    }
}
