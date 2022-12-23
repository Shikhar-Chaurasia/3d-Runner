using UnityEngine;
using UnityEngine.UI;

public class runnerplayer : MonoBehaviour
{
    private Horizontalcontrols hinput;
    public float zaxis = 3;
    public float speed =5;
    [Range(8.00f,12.00f)]
    public float speedH =10;
    public Slider touchin;
    public Rigidbody rb;
    public float horizontal;
    bool dead = false;
    public GameObject happyface;
    float i = 2f;
    // Start is called before the first frame update
    // Update is called once per frame

    void Awake(){
        hinput = new Horizontalcontrols();
        dead = false;
    }
    private void OnEnable() {
        hinput.Enable();
    }
    private void OnDisable() {
        hinput.Disable();
    }
    void FixedUpdate()
    {
        if(dead){
            return;
        }
        horizontal =hinput.player.move.ReadValue<float>();
        //horizontal = Input.GetAxis("Horizontal");
        Vector3 forwardmove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalmove = transform.right * speedH * horizontal * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardmove);
        if(transform.position.z > 3 && horizontal > 0){}
        else if(transform.position.z < -3 && horizontal < 0){}
        else{
            rb.MovePosition(rb.position + horizontalmove);
        }
        speed = speed + Time.deltaTime/50;
        speedH = speedH + Time.deltaTime/80;
        i -=Time.deltaTime;
        if(i < 0f && !dead){
            happyface.SetActive(false);
            i = 2f;
        }
        
        
    }
    public void deads(){
        dead = true;
    }
    public void collectcoin(){
        happyface.transform.GetChild(1).gameObject.SetActive(false);
        happyface.transform.GetChild(0).gameObject.SetActive(true);
        happyface.SetActive(true);
    }
   
}
