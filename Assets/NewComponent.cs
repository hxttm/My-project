using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Vector3 movement = new Vector3(0.05f, 0.05f, 0.05f);
    float limit= 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("This is a new component!");
        print(transform.position);
        print(transform.position.x);
        print(transform.position.y);
        print(transform.position.z);


    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= movement;
        transform.Rotate(30f * Time.deltaTime, 50f * Time.deltaTime, 20f * Time.deltaTime);

        if (transform.position.x> limit || 
        transform.position.x<-limit)
        {
            movement.x =- movement.y;
        }

        if (transform.position.y > limit || 
        transform.position.y < -limit)
                {
                    movement.y = -movement.y;
                }
        
        if (transform.position.z > limit || 
        transform.position.z < -limit)
            {
                movement.z = -movement.z;
            }
        }
    
}
