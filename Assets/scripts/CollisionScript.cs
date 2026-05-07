using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        print("Collision detected with" 
        + collision.gameObject.name);
    }
}