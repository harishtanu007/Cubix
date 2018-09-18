
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody player;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

	
	// Update is called once per frame
	void FixedUpdate () {
        player.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            player.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            player.AddForce(-sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
        }
        if (player.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}
}
