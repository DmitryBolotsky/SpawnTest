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
    
    void FixedUpdate()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (Time.time >= m_lastSpawn + m_interval) {
            var newCube = Instantiate(m_cubePrefab, transform.position, Quaternion.identity); 
            newCube.m_spawnPoint = transform;
            
            m_lastSpawn = Time.time;
        }
    }
}
