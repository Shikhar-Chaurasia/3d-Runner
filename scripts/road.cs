using UnityEngine;

public class road : MonoBehaviour
{
    public Roadmap rm;
    // Start is called before the first frame update
    void Start()
    {
        rm = GameObject.FindObjectOfType<Roadmap>();
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "player"){
            rm.spwanroad();
            rm.spwanroad();  
            rm.spwanroad();          
            Destroy(gameObject,2);
        }
    }
}
