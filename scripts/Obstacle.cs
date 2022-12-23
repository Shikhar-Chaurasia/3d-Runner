using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "player")
        {
            Destroy(gameObject,0.2f);
            GM.Lifesys();
        }
    }

    // Update is called once per frame

}
