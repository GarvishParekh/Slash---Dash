using System.Collections;
using UnityEngine;

public class FindPlatform : MonoBehaviour
{

    int myIndex = 0;
    [SerializeField] private Transform mainParent;
    [SerializeField] private Transform firstGround;
    [SerializeField] private Transform secondGround;

    private void Start()
    {
        myIndex = transform.GetSiblingIndex();

        StartCoroutine(nameof(Find));   
    }

    IEnumerator Find()
    {
        while (firstGround == null && secondGround == null)
        {
            if (mainParent.childCount > myIndex + 2)
            {
                firstGround = mainParent.GetChild(myIndex + 1);
                secondGround = mainParent.GetChild(myIndex + 2);

                Debug.Log("Finding.....");
            }
            else
            {
                Debug.Log("Waiting for index.....");
            }
            yield return null;
        }
        Debug.Log("Found");
    }
}
