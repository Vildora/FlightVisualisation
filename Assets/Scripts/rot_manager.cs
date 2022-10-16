using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rot_manager : MonoBehaviour
{
    //int Value = 10;
    public _Rotation rotat;
    public Text pitch;
    public Text roll;
    public Text eil_left;
    public Text eil_right;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(rotat.Rot_x);
       // Debug.Log(rotat.testing);
        
       // 
    }

    // Update is called once per frame
    void Update()
    {
        pitch.text = Main_Scene.Pitch.ToString();
        roll.text = Main_Scene.Roll.ToString();
        eil_left.text = Main_Scene.Rot_eil_right.ToString();
        eil_right.text = Main_Scene.Rot_eil_left.ToString();

    }
}
