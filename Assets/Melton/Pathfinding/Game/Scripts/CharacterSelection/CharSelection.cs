using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Melton
{
    public class CharSelection : MonoBehaviour
    {
        [SerializeField] Button button_druid;
        [SerializeField] Button button_mage;
        [SerializeField] Button button_priest;
        [SerializeField] Button button_warlock;

        List<MeltonCreature> characters;

        private void Awake(){
            button_druid.onClick.AddListener(() => 
            {
                LimitValidator(new Shaman());
            });

            button_mage.onClick.AddListener(() => 
            {
                LimitValidator(new Mage());
            });

            button_priest.onClick.AddListener(() => 
            {
                LimitValidator(new Priest());
            });

            button_warlock.onClick.AddListener(() => 
            {
                LimitValidator(new Warlock());
            });
        }

        private void LimitValidator(MeltonCreature creature){
            if (characters.Count<=4){
                if(!characters.Contains(creature))
                {
                    characters.Add(creature);
                }
                else{
                    characters.Remove(creature);
                }
            }
            
        }

        public List<MeltonCreature> getCreatureList()
        {
            return characters;
        }
    }
}
