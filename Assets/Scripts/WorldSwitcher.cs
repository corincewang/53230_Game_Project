using UnityEngine;

public class WorldSwitcher : MonoBehaviour
{
    public GameObject outerWorld;
    public GameObject innerWorld;

    private bool isInInnerWorld = false;

    void Start()
    {
        outerWorld.SetActive(true);
        innerWorld.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isInInnerWorld = !isInInnerWorld;

            outerWorld.SetActive(!isInInnerWorld);
            innerWorld.SetActive(isInInnerWorld);
        }
    }
}
