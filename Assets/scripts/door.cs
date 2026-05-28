using UnityEngine;

public class DoorScript : MonoBehaviour 
    { 
        Animator doorAnimator; bool playerNearby = false; bool isOpen = false; 
        void Start() 
            { 
                doorAnimator = GetComponent<Animator>(); 
            } 

            void Update() 
                { 
                    if (playerNearby && Input.GetKeyDown(KeyCode.E)) 
                        { 
                            isOpen = !isOpen; doorAnimator.SetBool("isOpen", isOpen); 
                        } 
                } 

                void OnTriggerEnter(Collider other) 
                    { 
                        if (other.CompareTag("Player")) { playerNearby = true; } 
                    }
                        void OnTriggerExit(Collider other) 
                            { 
                                if (other.CompareTag("Player")) { playerNearby = false; } 
                            } 
    }