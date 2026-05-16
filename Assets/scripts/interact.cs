using UnityEngine;

public class interact : MonoBehaviour
{
    GameObject currentCollectable;
    int collCount = 0;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectable")
        currentCollectable = collision.gameObject;
    }

    void OnInteract()
    {
        collCount++;
        print("Interacting with" + currentCollectable.name);
        collCount++;
        Destroy(currentCollectable);
    }

    void OnTriggered(Collider other)
    {
        if(other.gameObject.tag == "GoalArea" && collCount >= 7)
        {
            print("Player entered trigger zone with" + collCount + "collectables");
        }
    }
}
