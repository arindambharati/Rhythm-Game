using UnityEngine;

public class NoteObject : MonoBehaviour
{
    [SerializeField] private bool canBePressed;
    [SerializeField] private KeyCode keyToPress;
    [SerializeField] private bool isActive=false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            if (!isActive)
            {
                GameManager.Instance.MissedNotes();
            }
            
        }
    }

  
    void Update()
    {

        if (Input.GetKeyDown(keyToPress) && canBePressed)
        {
            isActive = true;
            gameObject.SetActive(false);
            GameManager.Instance.HitNotes();
        }
    }
}
