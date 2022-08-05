using UnityEngine;

public class playcollision : MonoBehaviour {

    public pmove movement;

    void OnCollisionEnter (Collision collisionInfo)
    {   
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManagement>().EndGame();
        }
    }

}