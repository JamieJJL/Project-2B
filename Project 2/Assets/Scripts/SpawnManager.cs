using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefabContainer;
    public AudioSource spawnSound; 

    public void EmptyContainer()
    {
        foreach (Transform child in prefabContainer.transform)
        {
            Destroy(child.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", 2, 2);
    }

    private void SpawnPrefab()
    {
        GameObject prefabInstance = Instantiate(prefab, transform.position, Quaternion.identity);
        prefabInstance.transform.SetParent(prefabContainer.transform);
        spawnSound.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
