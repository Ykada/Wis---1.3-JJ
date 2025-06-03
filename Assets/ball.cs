using UnityEngine;
public class Ball : MonoBehaviour
{
    public float speed = 7f;
    [SerializeField] private Transform A;
    [SerializeField] private Transform B;
    [SerializeField] private Transform ball;
    private Vector3 Vec;
    private Vector3 Dir;
    private float Dis;
    private float Dur;
    private float time = 0f;
    private bool ATB = true;
    void Start()
    {
        ball.position = A.position;
        Vec = B.position - A.position;
        Dis = Vec.magnitude;
        Dir = Vec.normalized;
        Dur = Dis / speed;
    }
    void Update()
    {
        time += Time.deltaTime;
        if (ATB)
        {
            Dir = (B.position - A.position).normalized;
        }
        else
        {
            Dir = (A.position - B.position).normalized;
        }
        ball.position += Dir * speed * Time.deltaTime;
        if (time > Dur)
        {
            time = 0f;
            ATB = !ATB;
        }
    }
}