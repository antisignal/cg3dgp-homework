using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterNineSight : MonoBehaviour
{
    public float distance;
    public float angle;
    public LayerMask obstaclesLayers;
    public LayerMask objectsLayers;
    public Collider detectedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);

        Vector3 rightDirection = Quaternion.Euler(0, angle, 0) * transform.forward;
        Gizmos.DrawRay(transform.position, rightDirection * distance);
        Vector3 leftDirection = Quaternion.Euler(0, -angle, 0) * transform.forward;
        Gizmos.DrawRay(transform.position, leftDirection * distance);

    }
    // Update is called once per frame
    void Update()
    {
        print("top of update");
        Collider[] colliders = Physics.OverlapSphere(
            transform.position, distance, objectsLayers
        );
        detectedObject = null;
        for (int i = 0; i < colliders.Length; i++)
        {
            print("collider " + i);
            Collider collider = colliders[i];
            Vector3 directionToCollider = Vector3.Normalize(
                collider.bounds.center - transform.position
            );
            float angleToCollider = Vector3.Angle(
                transform.forward, directionToCollider
            );
            if (angleToCollider < angle)
            {
                print("entering anglecollider < angle part of loop");
                if (!Physics.Linecast(transform.position, collider.bounds.center, out RaycastHit hit, obstaclesLayers))
                {
                    print("drawing green line");
                    Debug.DrawLine(transform.position, collider.bounds.center, Color.green);
                    detectedObject = collider;
                    break;
                }
                else
                {
                    print("drawing red line");
                    print("hit is" + hit);
                    Debug.DrawLine(transform.position, hit.point, Color.red);
                }
            }

        }
    }
}
