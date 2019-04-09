using UnityEngine;
using System.Collections;

public class scalingheat : MonoBehaviour
{

    public GameObject objectscale;

    public float scalingspeed = 0.01f;
    bool ScaleUp = false;
    bool ScaleDown = false;

    // Update is called once per frame
    void Update()
    {
        if (ScaleUp == true)
            ScaleUpButton();
        if (ScaleDown == true)
            ScaleDownButton();
    }

    public void ScaleUpButton()
    {
        objectscale.transform.localScale += new Vector3(scalingspeed, scalingspeed, scalingspeed);
    }
    public void ScaleDownButton()
    {
        objectscale.transform.localScale += new Vector3(-scalingspeed, -scalingspeed, -scalingspeed);
    }

    public void Up()
    {
        ScaleUp = true;
        ScaleDown = false;
    }
    public void Down()
    {
        ScaleUp = false;
        ScaleDown = true;
    }
    public void Stop()
    {
        ScaleUp = false;
        ScaleDown = false;
    }
}