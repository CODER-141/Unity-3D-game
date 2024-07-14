using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject{

    [SerializeField] private List<KitchenObjectSO> validkitchenObjectSOList;

    private List<KitchenObjectSO> kitchenObjectSOList;

    private void Awake() {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }
    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO) {
        if(!validkitchenObjectSOList.Contains(kitchenObjectSO)) {
            //Not a Valid ingredient
            return false;
        }
        if (kitchenObjectSOList.Contains(kitchenObjectSO)) {
            //Alrwady has this type
            return false;
        }else {
            kitchenObjectSOList.Add(kitchenObjectSO);
            return true;
        }
    }
}
