using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour {
    public float setslider = 100.0f;
    public GameObject Object;

    void Update(){
        Object.transform.localScale = new Vector3(0.12f, 0.12f, 0.12f) * setslider * 0.01f;
    }

    void OnGUI (){
        setslider = GUI.VerticalSlider(new Rect(30,500,180,400), setslider, 200.0f, 100.0f);
    }
}