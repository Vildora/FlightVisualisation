using System.Collections;
using UnityEngine;
using System;
using System.IO.Ports;
using UnityEngine.UI;

public class _Rotation : MonoBehaviour
{
    public GameObject right_w;
    public GameObject left_w;
    public float testing = 5f;
    public float Rot_x;
    public float Rot_z;
    public float Rot_eil_left;
    public float Rot_eil_right;
    public float local_x = 50.0f;
   // public Text pitch;
    //public Text roll;
    public string COM;
    //[SerializeField] public Button button6;
    [SerializeField] public Button button7;
    private bool canUse;
    public string receivedstring;
    private bool port_isopen;
    public SerialPort data_stream;
    


    void Start()
    {
    

            //button6.onClick.AddListener(check_button6);
            button7.onClick.AddListener(check_button7);
            //Debug.Log(Main_Scene.test);
            
            
        
    }

   
    void Update()
    {
        
        if(port_isopen)
        {
            try {
            receivedstring=data_stream.ReadLine();
            //Debug.Log(receivedstring);
            

             }  catch (System.Exception ex)
                {
                    Debug.Log("Read Error:" + ex.Message);
 
                }
        
             string[] datas =receivedstring.Split(',');
             Main_Scene.Pitch = Single.Parse(datas[0]); /// X rotation
             Main_Scene.Roll = Single.Parse(datas[1]); /// Z rotation
             Main_Scene.Rot_eil_left = Single.Parse(datas[2])*1.3f;
             Main_Scene.Rot_eil_right = Single.Parse(datas[3])*1.3f;
             transform.rotation = Quaternion.Euler(Main_Scene.Roll, 0, Main_Scene.Pitch);
             right_w.transform.localRotation = Quaternion.Euler(Main_Scene.Rot_eil_right, 0, 0);
             left_w.transform.localRotation = Quaternion.Euler(Main_Scene.Rot_eil_left*(-1f), 0, 0);
            //roll.text = datas[1];
            //pitch.text = testing.ToString();
            //pitch.text = datas[0];
            //Debug.Log(Single.Parse(datas[2]));
            //Debug.Log("ttt"+Rot_x);
             //Debug.Log("x="+transform.rotation.x.ToString());
           
            
        }  
 

    }


    // private void check_button6() 
    // {

    //     GameObject.Find("ChoosingPortUI").SetActive(false);


    //       data_stream = new SerialPort("COM6", 256000);
    //         data_stream.Open();
    //         data_stream.ReadTimeout=1000;
    //         if (data_stream.IsOpen) {
    //             Debug.Log("Open"); 
    //         port_isopen = true;}
    // }
    private void check_button7() 
    {

        GameObject.Find("COM7_Button").SetActive(false);
        data_stream = new SerialPort("COM8", 256000);
        data_stream.Open();
        data_stream.ReadTimeout=1000;
        if (data_stream.IsOpen) {
            Debug.Log("Open"); 
        port_isopen = true;}
    }
}
