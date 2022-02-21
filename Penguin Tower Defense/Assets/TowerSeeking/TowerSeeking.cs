using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class TowerSeeking : MonoBehaviour
{

    void FixedUpdate()
    {
        int RaysToShoot = 60;
        int RayDistance = 2;
        float angle = 0;
        LayerMask pirates = LayerMask.GetMask("pirates");


        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 2f, pirates);
        
        if (colliders.Length > 0)
        {


            string name = colliders[0].name;
            
            Debug.Log(name);
            for (int i = 0; i < RaysToShoot; i++)
            {
                float x = Mathf.Sin(angle);
                float y = Mathf.Cos(angle);
                angle += 2 * Mathf.PI / RaysToShoot;
                Vector3 dir = new Vector3(transform.position.x + x * RayDistance, transform.position.y + y * RayDistance, 0);
                //Debug.Log("hitten");
                RaycastHit2D hit = Physics2D.Raycast(dir, dir);
                Debug.DrawLine(transform.position, dir, Color.green);
                if (hit && name == hit.collider.name ) 
                {
                           
                        Vector3 hitPosition = hit.point;
                        transform.right = hitPosition - transform.position;
                        Debug.DrawLine(transform.position, hit.point, Color.red);

                       // Debug.Log("HIT: " + hit.collider.name);
                    
                }
            }
        }
    }
            void OnDrawGizmosSelected()
            {
                // Draw a yellow sphere at the transform's position
                Gizmos.color = Color.yellow;
                Gizmos.DrawSphere(transform.position, 10);
            }



        }
    
    
