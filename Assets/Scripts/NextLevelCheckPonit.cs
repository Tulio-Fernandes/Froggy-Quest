using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelCheckPoint : MonoBehaviour
{
    public string lvName;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvName);
        }
    }
}
