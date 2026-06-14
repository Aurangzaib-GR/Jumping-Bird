using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject obstaclePrefab;
    private float timer = 0f;
    public bool isGameOver = false;
    public GameObject GameOverPanel;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        isGameOver = false;
        GameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (timer <= 0f)
        {
            if (isGameOver == false)
            {
                // Spawn obstacle
                GameObject gm = Instantiate(obstaclePrefab, new Vector3(3.80f, Random.Range(-0.74f, 1.77f), 0f), Quaternion.identity);
                Destroy(gm, 2f);
                // Reset timer
                timer = 0.88f;
            }

        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
    public void RetryButtion()
    {
        Debug.Log("Retry button clicked!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
