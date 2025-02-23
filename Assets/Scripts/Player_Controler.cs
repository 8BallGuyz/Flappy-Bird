using UnityEngine;

public class Player_Contrroler : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float score;

    public Canvas gameover;

    public bool movement_controller = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        gameover.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (movement_controller == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.linearVelocity = Vector2.zero;
                rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pipe"))
        {
            Debug.Log("Pipe Passed");
            score = score + 1;
        }

        if (collision.CompareTag("collision"))
        {
            movement_controller = false;
            gameover.gameObject.SetActive(true);
        }
    }
}
