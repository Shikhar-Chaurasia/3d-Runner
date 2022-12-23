using UnityEngine;

public class COINS : MonoBehaviour
{
    // Start is called before the first frame update
    public float coins = 0;
    public GameManager GM;

    // Update is called once per frame

    void Awake(){
        GM = GameObject.FindObjectOfType<GameManager>();
    }
    void Update()
    {
        transform.Rotate(0,0,(90f* Time.deltaTime));
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "player"){
            Destroy(gameObject);
            GM.Coinsys();
        }
    }
}
