using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorCameraOrbit : MonoBehaviour
{
    // ���E��]�p�̌����̃I�t�Z�b�g
    public int HorizontalOffset = 1;
    // �㉺��]�p�̌����̃I�t�Z�b�g
    public int VerticalOffset = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.eulerAngles += new Vector3(
                Input.GetAxis("Mouse Y") * VerticalOffset,
                Input.GetAxis("Mouse X") * HorizontalOffset,
                0f
            );
        }
    }
}
