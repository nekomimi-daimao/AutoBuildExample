using UnityEngine;

public class ShowState : MonoBehaviour
{
    private const PrimitiveType Type = PrimitiveType.Capsule;

    private void Start()
    {
        GameObject.CreatePrimitive(Type);
    }
}
