using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;
    public int Score;
    public AudioClip collectSound;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            GameController.instance.totalScore += Score;
            GameController.instance.UpdateSocreText();

            Destroy(gameObject, 0.25f);
        }
    }
}
