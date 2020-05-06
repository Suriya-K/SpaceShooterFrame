using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    [Range(1, 100)]
    public int maximumSize;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy1());

    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator spawnEnemy1()
    {
        while (count < maximumSize)
        {
            GameObject e = Instantiate(enemy, new Vector3(Random.Range(-500f, 500f), Random.Range(-500f, 500f), Random.Range(-500f, 500f)), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            count++;
        }
    }
}
