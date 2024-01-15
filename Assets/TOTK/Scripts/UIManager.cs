using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _abilityCrosshair;

    // Start is called before the first frame update
    void Start()
    {
        _abilityCrosshair.gameObject.SetActive(false);
        PlayerAbilities.activateAbility += ToggleAbilityCrosshair;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        PlayerAbilities.activateAbility -= ToggleAbilityCrosshair;
    }

    private void ToggleAbilityCrosshair(int abilityState)
    {
        if (abilityState > 0)
        {
            _abilityCrosshair.gameObject.SetActive(true);
        }
        else
        {
            _abilityCrosshair.gameObject.SetActive(false);
        }
    }
}
