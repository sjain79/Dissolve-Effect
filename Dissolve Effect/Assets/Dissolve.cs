using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour {

	void Start ()
    {
        //dissolve = Shader.Find("graphs/Dissolve");
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<SkinnedMeshRenderer>().material.SetFloat("Vector1_950447AF", Mathf.Lerp(GetComponent<SkinnedMeshRenderer>().material.GetFloat("Vector1_950447AF"), 1.0f, 0.025f));
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<SkinnedMeshRenderer>().material.SetFloat("Vector1_950447AF", Mathf.Lerp(GetComponent<SkinnedMeshRenderer>().material.GetFloat("Vector1_950447AF"), 0, 0.025f));
        }
    }
}
