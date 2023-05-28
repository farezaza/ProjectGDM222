using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite PressedImage;

    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();

        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        // No need for update logic since we are using button click events
    }

    private void OnButtonClick()
    {
        theSR.sprite = PressedImage;
        Invoke(nameof(ResetSprite), 0.1f);
    }

    private void ResetSprite()
    {
        theSR.sprite = defaultImage;
    }
}
