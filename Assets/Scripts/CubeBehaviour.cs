using System;
using UnityEngine;
using UnityEngine.UI;
public class CubeBehaviour : MonoBehaviour
{
    [SerializeField]
    internal float m_speed = 0.1f;
    [SerializeField]
    internal float m_distance = 30.0f;
    [SerializeField]
    internal Transform m_spawnPoint;
    

    
    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if(!gameObject.active)
            return;
        if (Vector3.Distance (m_spawnPoint.position,transform.position) >= m_distance) {
            gameObject.SetActive(false);
            return;
        }
        var translation = new Vector3(1,0,0);
        translation = translation.normalized * m_speed;
        transform.Translate (translation);
        
    }
}
