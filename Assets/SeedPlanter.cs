using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlanter : MonoBehaviour
{
    // Public variables for customization
    public GameObject seedPrefab;
    public float rayDistance = 10f;
    public LayerMask groundLayer;

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            PlantSeed();
        }
    }

    void PlantSeed()
    {
        // Perform a raycast from the center of the screen
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance, groundLayer))
        {
            GameObject seed = Instantiate(seedPrefab, hit.point, Quaternion.identity);

        

            
            float randomYRotation = Random.Range(0f, 360f);
            seed.transform.rotation = Quaternion.Euler(0, randomYRotation, 0);



            float randomScale = 1f + Random.Range(-0.2f, 0.2f);
            seed.transform.localScale = new Vector3(randomScale, randomScale, randomScale);   
        }
    }
}
