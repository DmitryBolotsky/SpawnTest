using UnityEngine;
public class CubeBehaviour : MonoBehaviour
{
    [SerializeField]
    private float m_speed = 0.1f;
    [SerializeField]
    private float m_distance = 30.0f;

    [SerializeField] 
    public Transform m_spawnPoint;

    
    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if (Vector3.Distance (m_spawnPoint.position,transform.position) >= m_distance) {
            Destroy (gameObject);
            return;
        }
        var translation = new Vector3(1,0,0);
        if (translation.magnitude > m_speed) {
            translation = translation.normalized * m_speed;
        }
        transform.Translate (translation);
        
    }
}
