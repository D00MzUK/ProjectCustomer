using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUI : MonoBehaviour
{
    public GameObject Target;
    private float m_Speed;
    public Slider SliderDis;

    void Start()
    {
        m_Speed = 10.0f;
    }

    void Update()
    {
        /*if (SliderDis.value <= 0.45f)
        {
            Target.transform.position = new Vector3(0.0f, -17, SliderDis.value);
        }

        if (SliderDis.value >= 0.55f)
        {
            Target.transform.position = new Vector3(0.0f, -17, SliderDis.value);
        }*/

        Target.transform.position += new Vector3(0.0f, 0.0f, SliderDis.value);
    }
}