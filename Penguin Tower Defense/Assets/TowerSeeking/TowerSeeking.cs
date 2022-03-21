using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TowerSeeking : shoot
{
    // bool angående vad som ska targetas, används inte ännu
    [SerializeField] private bool targetFirst = true;
    // hur långt tornet ser och kan targeta skepp
    [SerializeField][Range(2, 15)] private float Range = 1;

    void FixedUpdate()
    {

        int which2target = 0;



        /*
        int RaysToShoot = 60;
        int RayDistance = 2;
        float angle = 0;
        */

        LayerMask pirates = LayerMask.GetMask("pirates");
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, Range, pirates);
        
        if (colliders.Length > 0)
        {


            float howFar = colliders[0].GetComponent<FollowPath>().HowFarIn;
            // här kollar vi vilken av skeppen som har kommit längst på banan beroende på en float som ligger i followath sripten
            for (int i = 0; i < colliders.Length; i++)
            {
                if(howFar < colliders[i].GetComponent<FollowPath>().HowFarIn) { 
                    howFar = colliders[i].GetComponent<FollowPath>().HowFarIn;
                    which2target = i;
                }
            }

               // shooting();

                // Räknar ut vikeln mellan två positioner alltså skeppets XY position och tornets XY position.
                // I samma veva omvandlar vi radianerna till vanliga grader med "(180 / Mathf.PI) *".
                float lookAtAngle = (180 / Mathf.PI) * Mathf.Atan2(colliders[which2target].transform.position.y - transform.position.y, colliders[which2target].transform.position.x - transform.position.x);
                //Sen roterar vi tornet i Z leden eftersom det är så man får till två dimensioell rotation.
                transform.rotation = Quaternion.Euler(0, 0, lookAtAngle);

        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, Range);
    }


    // Albin Kod


    //string name = colliders[which2target].name;

    /*
    for (int i = 0; i < RaysToShoot; i++)
    {
        float x = Mathf.Sin(angle);
        float y = Mathf.Cos(angle);
        angle += 2 * Mathf.PI / RaysToShoot;
        Vector3 dir = new Vector3(transform.position.x + x * RayDistance, transform.position.y + y * RayDistance, 0);
        RaycastHit2D hit = Physics2D.Raycast(dir, dir);
        Debug.DrawLine(transform.position, dir, Color.green);

    }*/

    // if (hit && name == hit.collider.name)
    //{

    // Debug.DrawLine(transform.position, hit.point, Color.red);


}


