// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using System.IO.Ports;

// public class ChoosingCOM6 : MonoBehaviour
// {
//     [SerializeField] private Button button6;
//     [SerializeField] private Button button7;    
//     public GameObject image;





//     private bool used;

//     void Update()
//     {
//         if(used == false) {
//             button6.onClick.AddListener(setCOM6);
//             //button7.onClick.AddListener(setCOM7);
//             used = true;
            
//         }
        
//     }
//     private void setCOM6() 
//     {
//         GameObject.Find("/Plane").GetComponent<_Rotation>().port_isopen = true;
//         public SerialPort data_stream = new SerialPort("COM6", 115200);
//         data_stream.Open();
//         data_stream.ReadTimeout=1000;
//         if (data_stream.IsOpen) {Debug.Log("Open"); }
//         receivedstring=data_stream.ReadLine();
//         print("changed value of port");
//     }
//}   
