using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public GameObject hitEffects;

    public UnityEngine.UI.Button noteButton;

    // Start is called before the first frame update
    void Start()
    {
        noteButton.onClick.AddListener(OnNoteButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        // No need for update logic since we are using button click events
    }

    private void OnNoteButtonClick()
    {
        if (canBePressed)
        {

            GameManager.instance.NoteHit();
            Instantiate(hitEffects, transform.position, hitEffects.transform.rotation);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && gameObject.activeSelf)
        {
            canBePressed = false;
            GameManager.instance.NoteMisses();
        }
    }
}
