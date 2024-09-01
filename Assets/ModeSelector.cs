using UnityEngine;

public class ModeSelector : MonoBehaviour
{
    public int currentMode = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentMode = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentMode = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentMode = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentMode = 4;
        }
    }
}
