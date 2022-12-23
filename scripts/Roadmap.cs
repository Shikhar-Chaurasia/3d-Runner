using UnityEngine;

public class Roadmap : MonoBehaviour
{
    public GameObject road;
    Vector3 swamppoint;
   // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            GameObject Tem = Instantiate(road,swamppoint,Quaternion.identity,transform);
            swamppoint = Tem.transform.GetChild(0).transform.position;
            int randomindex = Random.Range(3,6);
            Tem.transform.GetChild(randomindex).gameObject.SetActive(true);
        }            
    }
    
    public void spwanroad(){
        if(transform.childCount > 7){
            Debug.Log("more than 7");
            return;}
        GameObject Tem = Instantiate(road,swamppoint,Quaternion.identity,transform);
        swamppoint = Tem.transform.GetChild(0).transform.position;
        int randomindex = Random.Range(1,12);
        Tem.transform.GetChild(randomindex).gameObject.SetActive(true);
        
    }
    // Update is called once per frame
    
}
