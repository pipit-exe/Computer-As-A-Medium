using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject objectToAppear;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToAppear.SetActive(true);
            Destroy(gameObject);
        }
    }
}