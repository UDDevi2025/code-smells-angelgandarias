using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject prefab;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    public int coinAmount;

    private void Awake()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        for (int i = 0; i < coinAmount; i++)
        {
            var go = Instantiate<GameObject>(prefab);

            float x = Random.Range(minX, maxX);
            float y = 0.5f;
            float z = Random.Range(minZ, maxZ);

            go.transform.position = new Vector3(x, y, z);
        }
    }
}
