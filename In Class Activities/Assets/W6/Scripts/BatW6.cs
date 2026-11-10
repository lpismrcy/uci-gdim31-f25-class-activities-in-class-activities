using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] public float _speed;
    [SerializeField] public Transform _player;


    public void Chase()
    {
        float iSpeed = _speed;
        transform.position = Vector3.MoveTowards(transform.position, _player.position, iSpeed * Time.deltaTime);

    }

    public void disable()
    {
        enabled = false;
    }

}
