using UnityEngine;

public class NoteObject : MonoBehaviour
{
    [SerializeField] private bool canBePressed;
    [SerializeField] private KeyCode keyToPress;

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
        }
    }

  
    void Update()
    {

        if (Input.GetKeyDown(keyToPress) && canBePressed)
        {
            gameObject.SetActive(false);
        }
    }
}
