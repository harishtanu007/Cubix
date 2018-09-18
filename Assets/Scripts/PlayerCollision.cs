using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement playerMovement;
    // Use this for initialization
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
