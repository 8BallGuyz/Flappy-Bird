using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_manager : MonoBehaviour
{
    public Text scoreText;
    public Player_Contrroler player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = " " + player.score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        player.movement_controller = true;
        player.gameover.gameObject.SetActive(false);
    }
}
