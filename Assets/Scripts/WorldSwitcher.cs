using UnityEngine;

public class WorldSwitcher : MonoBehaviour
{
    public GameObject outerWorld;
    public GameObject innerWorld;
    public Camera mainCamera;

    public Color outerColor = Color.grey;
    public Color innerColor = new Color(0.3f, 0.2f, 0.5f);

    private bool isInInnerWorld = false;
    private bool hasMemoryItem = false;

    void Start()
    {
        outerWorld.SetActive(true);
        innerWorld.SetActive(false);

        if (mainCamera != null)
        {
            mainCamera.backgroundColor = outerColor;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && hasMemoryItem)
        {
            isInInnerWorld = !isInInnerWorld;

            outerWorld.SetActive(!isInInnerWorld);
            innerWorld.SetActive(isInInnerWorld);

            if (mainCamera != null)
            {
                mainCamera.backgroundColor = isInInnerWorld ? innerColor : outerColor;
            }
        }
    }

    public void CollectMemoryItem()
    {
        hasMemoryItem = true;
    }
}
