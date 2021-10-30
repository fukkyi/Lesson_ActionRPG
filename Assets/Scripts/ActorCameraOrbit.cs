using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorCameraOrbit : MonoBehaviour
{
    // 左右回転用の向きのオフセット
    public int HorizontalOffset = 1;
    // 上下回転用の向きのオフセット
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
