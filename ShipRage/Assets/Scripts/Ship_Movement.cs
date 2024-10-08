using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public int moveSpeed;
	public float x = 0;
	public float y = 0;
	public float timeToSlide;

	public Rigidbody rb;

	string player;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

		if (this.CompareTag("Player1"))
			player = "1";
		else if (this.CompareTag("Player2"))
			player = "2";
	}

    // Update is called once per frame
    void Update()
    {
		if (!Pause_Menu_Scripts.MyInstance.IsPaused)
		{
            if (Keybindings_Manager.MyInstance.KeyDown("moveLeft" + player))
                x = -1;

            if (Keybindings_Manager.MyInstance.KeyDown("moveRight" + player))
                x = 1;

            if (Keybindings_Manager.MyInstance.KeyDown("moveLeft" + player) && Keybindings_Manager.MyInstance.KeyDown("moveRight" + player))
                x = 0;



            if (Keybindings_Manager.MyInstance.KeyDown("moveUp" + player))
                y = 1;

            if (Keybindings_Manager.MyInstance.KeyDown("moveDown" + player))
                y = -1;

            if (Keybindings_Manager.MyInstance.KeyDown("moveUp" + player) && Keybindings_Manager.MyInstance.KeyDown("moveDown" + player))
                y = 0;



            if (!Keybindings_Manager.MyInstance.KeyDown("moveLeft" + player) && !Keybindings_Manager.MyInstance.KeyDown("moveRight" + player) && x > 0)
            {
                x -= 5f * Time.deltaTime;
                if (x < timeToSlide)
                    x = 0;
            }
            if (!Keybindings_Manager.MyInstance.KeyDown("moveLeft" + player) && !Keybindings_Manager.MyInstance.KeyDown("moveRight" + player) && x < 0)
            {
                x += 5f * Time.deltaTime;
                if (x > -(timeToSlide))
                    x = 0;
            }

            if (!Keybindings_Manager.MyInstance.KeyDown("moveUp" + player) && !Keybindings_Manager.MyInstance.KeyDown("moveDown" + player) && y > 0)
            {
                y -= 5f * Time.deltaTime;
                if (y < timeToSlide)
                    y = 0;
            }
            if (!Keybindings_Manager.MyInstance.KeyDown("moveUp" + player) && !Keybindings_Manager.MyInstance.KeyDown("moveDown" + player) && y < 0)
            {
                y += 5f * Time.deltaTime;
                if (y > -(timeToSlide))
                    y = 0;
            }

            rb.velocity = new Vector3(x, y, rb.velocity.z) * moveSpeed;
        }
	}
}