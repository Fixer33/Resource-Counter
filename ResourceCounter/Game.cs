using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//Made by Fixer33
//https://github.com/Fixer33

namespace ResourceCounter
{
    [DataContract]
    class Game
    {
        [DataMember]
        public string game_name;
        [DataMember]
        public List<Component> all_components;

        public Component this[int index]
        {
            get
            {
                return all_components[index];
            }
        }

        public void SetGameName(string game_name)
        {
            this.game_name = game_name;
        }

        public Component FindComponentByName(string name)
        {
            foreach (Component component in all_components)
            {
                if (component.name == name) return component;
            }
            return null;
        }

        public int FindComponentId(Component comp)
        {
            for (int i = 0; i < all_components.Count; i++)
            {
                if (all_components[i].name == comp.name) return i;
            }
            return -1;
        }

        #region Constructors
        public Game()
        {
            this.game_name = "game_unknown";
            this.all_components = new List<Component>();
        }
        public Game(string game_name)
        {
            this.game_name = game_name;
            this.all_components = new List<Component>();
            //Made by Fixer33
            //https://github.com/Fixer33
        }
        #endregion
    }
}
