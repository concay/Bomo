using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pm;
    void OnCollisionEnter(Collision collisonInfo) {
        if(collisonInfo.collider.tag == "Obstacle"){
            pm.enabled = false;
            GameManager gm = FindObjectOfType<GameManager>();
            gm.EndGame();
        }
    }
}
