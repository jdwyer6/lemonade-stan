using UnityEngine;
using System.Collections;

public class Lemon_Tree : MonoBehaviour
{
    public int growthCycleTimeMin = 2;
    public int growthCycleTimeMax = 5;
    public GameObject[] cycleModels;
    private int growthCycle = 0;
    private GameObject player;
    public bool readyToHarvest = false;
    
    void Start()
    {
        StartCoroutine(InitLifeCycle());
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator InitLifeCycle()
    {
        while (true)
        {
            UpdateGrowthCycle();
            yield return new WaitForSeconds(GetRandomNumber(growthCycleTimeMin, growthCycleTimeMax));
            
            if (growthCycle >= cycleModels.Length)
            {
                yield break;
            }
            
        }
    }


    int GetRandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }

    void Harvest()
    {
        player.GetComponent<Cash>().AddCash(1);
        growthCycle = 0;
        UpdateGrowthCycle();
    }

    private void UpdateGrowthCycle()
    {
        Quaternion currentRotation = transform.rotation;

        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        
        Instantiate(cycleModels[growthCycle], transform.position, currentRotation, transform);
        growthCycle++;
        
        if (growthCycle >= cycleModels.Length)
        {
            readyToHarvest = true;
        }
    }
}
