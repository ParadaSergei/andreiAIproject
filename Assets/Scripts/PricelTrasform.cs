using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PricelTrasform : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private RaycastHit hit;
    private Ray ray;
    void Start()
    {
        
    }

    void Update()
    {
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit))
        {
            transform.position = hit.point;  
        }
    }
}
