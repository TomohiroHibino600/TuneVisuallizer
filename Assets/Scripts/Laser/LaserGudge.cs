using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Crosstales.Radio;

public class LaserGudge : MonoBehaviour
{
    [SerializeField] Transform rayOrigin = null;
    [SerializeField] LaserPointer laserPointer = null;
    [SerializeField] SimplePlayer simplePlayer = null;
    [SerializeField] float maxRayDistance = 100.0f;

    void Update( ) {
        // 右手のコントローラの位置と向いている方向からRayを作成
        Ray ray = new Ray( rayOrigin.position, laserPointer._forward );

        // 作成したRay上にColliderがあるか判定
        RaycastHit hit;

        if ( Physics.Raycast( ray, out hit, maxRayDistance ) ) {
            if ( Input.GetKey( KeyCode.Space ) | OVRInput.GetDown( OVRInput.RawButton.RIndexTrigger ) ) {
                if ( hit.collider.gameObject.tag == "Play" ) {
                    simplePlayer.Play( );
                }

                if ( hit.collider.gameObject.tag == "Stop" ) {
                    simplePlayer.Stop( );
                }

                if ( hit.collider.gameObject.tag == "Next" ) {
                    simplePlayer.Next( );
                }

                if ( hit.collider.gameObject.tag == "Previous" ) {
                    simplePlayer.Previous( );
                }
            }
        }
    }
}
