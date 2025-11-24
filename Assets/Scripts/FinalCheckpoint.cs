using UnityEngine;

public class FinalCheckpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameController.instance != null)
            {
                GameController.instance.ShowVictory();
            }
        }
    }
}
