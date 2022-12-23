using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform player;
    public float dis;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3((dis + player.position.x) ,transform.position.y,transform.position.z) ;
    }
}
