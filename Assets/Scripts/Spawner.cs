using System;
using UnityEngine;
using  UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] 
    internal float m_interval = 2;
    private float m_lastSpawn = 0;
    [SerializeField] 
    private CubeBehaviour m_cubePrefab;
    [SerializeField]
    private int m_poolCount = 10;
    private PoolMono<CubeBehaviour> m_pool;
    private bool m_autoExpand = true;
    
    
    private void Start()
    {
        m_cubePrefab.m_spawnPoint = transform;
        m_pool = new PoolMono<CubeBehaviour>(m_cubePrefab, m_poolCount, transform);
        m_pool.autoExpand = m_autoExpand;
    }
    void FixedUpdate()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (Time.time >= m_lastSpawn + m_interval)
        {
            var newCube = m_pool.GetFreeElement();
            newCube.transform.position = transform.position;
            
            m_lastSpawn = Time.time;
        }
    }
}
