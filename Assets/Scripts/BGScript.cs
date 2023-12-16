using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BGScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private MeshRenderer _renderer;

    private Vector2 _meshOffset;
    void Start()
    {
        _meshOffset = _renderer.sharedMaterial.mainTextureOffset;
    }

    private void OnDisable()
    {
        _renderer.sharedMaterial.mainTextureOffset = _meshOffset;
    }

    void Update()
    {
        var x = Mathf.Repeat(Time.time * _speed, 1);
        var offset = new Vector2(x, _meshOffset.y);

        _renderer.sharedMaterial.mainTextureOffset = offset;
    }
}
