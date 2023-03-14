using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;


public class androidRotate : MonoBehaviour
{

    public fixedTouchField touchField;

    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        var fps = GetComponent<FirstPersonController>();

        fps.m_MouseLook.lookAxis = touchField.TouchDist;
    }
}