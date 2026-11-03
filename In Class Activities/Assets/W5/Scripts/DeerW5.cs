using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5: MonoBehaviour
{
    [SerializeField] private GameObject objectToWalkTowards;

    void Start()
    {
        NavMeshAgent deerMesh = GetComponent<NavMeshAgent>();
        Vector3 locationToMoveTo = objectToWalkTowards.GetComponent<Transform>().position;
        deerMesh.SetDestination(locationToMoveTo);
    }
}