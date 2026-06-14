using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameOver == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

    }

}
