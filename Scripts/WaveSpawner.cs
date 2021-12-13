
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab1;
    public Transform enemyPrefab2;
    public Transform enemyPrefab3;
    public Transform enemyPrefab4;
    public Transform enemyPrefab5;
    public Transform spawnPoint;

    public float timeBetweenEnemy1 = 6f;
    public float timeBetweenEnemy2 = 8f;
    public float timeBetweenEnemy3 = 4f;
    public float timeBetweenEnemy4 = 6f;
    public float timeBetweenEnemy5 = 30f;
    private float countdown1 = 3f;
    private float countdown2 = 5f;
    private float countdown3 = 1.5f;
    private float countdown4 = 3.5f;
    private float countdown5 = 4f;
    private float waveCountdown = 60f;

    public Text enemyNumText;
    public static int waveCount = 1;
    PlayerStats playerStats;
    private void Start()
    {
        playerStats = PlayerStats.instance;
    }

    void Update()
    {
        if (waveCount == 1)
        {
            if (countdown1 <= 0f)
            {
                StartCoroutine(SpawnWave1());
                countdown1 = timeBetweenEnemy1;
            }
            if (countdown2 <= 0f)
            {
                StartCoroutine(SpawnWave2());
                countdown2 = timeBetweenEnemy2;
            }
        }
        if (waveCount == 2)
        {
            if (countdown1 <= 0f)
            {
                StartCoroutine(SpawnWave1());
                countdown1 = timeBetweenEnemy1;
            }
            if (countdown2 <= 0f)
            {
                StartCoroutine(SpawnWave2());
                countdown2 = timeBetweenEnemy2;
            }
            if (countdown3 <= 0f)
            {
                StartCoroutine(SpawnWave3());
                countdown3 = timeBetweenEnemy3;
            }
            if (countdown4 <= 0f)
            {
                StartCoroutine(SpawnWave4());
                countdown4 = timeBetweenEnemy4;
            }
        }
        if (waveCount == 3)
        {
            if (countdown1 <= 0f)
            {
                StartCoroutine(SpawnWave1());
                countdown1 = timeBetweenEnemy1;
            }
            if (countdown2 <= 0f)
            {
                StartCoroutine(SpawnWave2());
                countdown2 = timeBetweenEnemy2;
            }
            if (countdown3 <= 0f)
            {
                StartCoroutine(SpawnWave3());
                countdown3 = timeBetweenEnemy3;
            }
            if (countdown4 <= 0f)
            {
                StartCoroutine(SpawnWave4());
                countdown4 = timeBetweenEnemy4;
            }
            if (countdown5 <= 0f)
            {
                StartCoroutine(SpawnWave5());
                countdown5 = timeBetweenEnemy5;
            }
        }
        if (waveCount == 4)
        {
            
               PlayerStats.Clear();
            
        } 



        if (waveCountdown <= 0f)
        {
            waveCount += 1;
            waveCountdown = 60f;

            PlayerStats.Money += 30;
        }
        countdown1 -= Time.deltaTime;
        countdown2 -= Time.deltaTime;
        countdown3 -= Time.deltaTime;
        countdown4 -= Time.deltaTime;
        countdown5 -= Time.deltaTime;
        waveCountdown -= Time.deltaTime;

        enemyNumText.text = ("ÀûÀÇ ¼ö" + Enemy.enemyCount.ToString());
    }

    IEnumerator SpawnWave1()
    {
        SpawnEnemy1();
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator SpawnWave2()
    {
        SpawnEnemy2();
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator SpawnWave3()
    {
        SpawnEnemy3();
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator SpawnWave4()
    {
        SpawnEnemy4();
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator SpawnWave5()
    {
        SpawnEnemy4();
        yield return new WaitForSeconds(0.5f);
    }
    void SpawnEnemy1()
    {
        Instantiate(enemyPrefab1, spawnPoint.position, spawnPoint.rotation);
        Enemy.enemyCount++;
    }
    void SpawnEnemy2()
    {
        Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);
        Enemy.enemyCount++;
    }
    void SpawnEnemy3()
    {
        Instantiate(enemyPrefab3, spawnPoint.position, spawnPoint.rotation);
        Enemy.enemyCount++;
    }
    void SpawnEnemy4()
    {
        Instantiate(enemyPrefab4, spawnPoint.position, spawnPoint.rotation);
        Enemy.enemyCount++;
    }
    void SpawnEnemy5()
    {
        Instantiate(enemyPrefab4, spawnPoint.position, spawnPoint.rotation);
        Enemy.enemyCount++;
    }

  
}
  


