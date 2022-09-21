using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{
    public GameObject[] section;

    public int zpos = 0;
    public int xpos = 1000;
    private int sectionNumber;

    public bool createSection = false;

    void Update()
    {
        if (createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }    
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 3);
        Instantiate(section[sectionNumber], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 100;
        yield return new WaitForSeconds(20);
        createSection = false;
    }
}
