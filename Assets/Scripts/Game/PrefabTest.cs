using UnityEngine;


public class PrefabTest : MonoBehaviour
{
    // Reference to the Prefab.
    public GameObject myPrefab;

    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, new Vector2(0, 0), Quaternion.identity);
    }

}