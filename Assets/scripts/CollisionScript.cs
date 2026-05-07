using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        print("Collision detected with" 
        + collision.gameObject.name);
        if(collision.gameObject.name=="NestedParent_Unpack")
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        print("Collision ended with"
        + collision.gameObject.name);
    }

    void OnCollisionStay(Collision collision)
    {
        print("Colliding with"
        + collision.gameObject.name);
    }
}