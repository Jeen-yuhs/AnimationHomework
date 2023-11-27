using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _gameObject;

    private bool _enabled = false;

    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(DisableObject);
    }

    // Update is called once per frame
    public void DisableObject(GameObject gameObject) 
    {
        _enabled ^= true;
        
        gameObject.SetActive(_enabled); 
    }

    public void DisableObject()
    {
        _gameObject.SetActive(false);
    }
}
