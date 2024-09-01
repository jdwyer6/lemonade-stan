using UnityEngine;

public class Cash : MonoBehaviour
{
    public int cash = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCash(int amount)
    {
        cash += amount;
    }
}
