using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    Void OnCollisionEnter(Collision collision)
    {
        print("Collision detected!");
    }
}