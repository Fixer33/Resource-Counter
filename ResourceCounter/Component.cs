using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Made by Fixer33
//https://github.com/Fixer33

namespace ResourceCounter
{
    [DataContract]
    class Component
    {
        
        public Game game_to_attach;
        [DataMember]
        public string name;
        [DataMember]
        public ComponentType componentType;
        [DataMember]
        public List<(int component_id, decimal count)> recipe_components = null;
        //public List<(int component_id, decimal count)> recipe_components = null;
        
        public Component(string name, Game game)
        {
            this.name = name;
            this.game_to_attach = game;
            componentType = ComponentType.Resource;
        }

        public List<(int component_id, decimal count)> CalculateResources()
        {
            List<(int component_id, decimal count)> Result = new List<(int component_id, decimal count)>();

            foreach (var item in recipe_components)
            {
                if (game_to_attach[item.component_id].componentType == ComponentType.Resource)
                {
                    Result.Add(item);
                }
            }

            foreach (var item in recipe_components)
            {
                if (game_to_attach[item.component_id].componentType == ComponentType.Recipe)
                {
                    var recurs_result = game_to_attach[item.component_id].CalculateResources();
                    List<(int component_id, decimal count)> temp = new List<(int component_id, decimal count)>();
                    for (int i = 0; i < item.count; i++)
                    {
                        temp = MergeComponentLists(temp, recurs_result);
                    }
                    Result = MergeComponentLists(Result, temp);
                }
            }

            return Result;
        }

        private List<(int component_id, decimal count)> MergeComponentLists(List<(int component_id, decimal count)> list1, List<(int component_id, decimal count)> list2)
        {
            List<(int component_id, decimal count)> Result = new List<(int component_id, decimal count)>();
            foreach (var item in list1)
            {
                Result.Add(item);
            }
            foreach (var item in list2)
            {
                int index_in_list1 = FindComponentIdInList(Result, item.component_id);
                if (index_in_list1 >= 0)
                {
                    var elem = Result[index_in_list1];
                    elem.count += item.count;
                    Result[index_in_list1] = elem;
                }
                else
                {
                    Result.Add(item);
                }
            }
            return Result;
        }

        private int FindComponentIdInList(List<(int component_id, decimal count)> list, decimal comp)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].component_id == comp) return i;
            }
            return -1;
        }

        public void AddRecipeComponent(Component comp, decimal count)
        {
            //Search for already existing element
            int index = -1;
            for (int i = 0; i < recipe_components.Count; i++)
            {
                if (game_to_attach[recipe_components[i].component_id].name == comp.name) index = i;
            }
            if (index == -1)
            {
                recipe_components.Add((game_to_attach.FindComponentId(comp), count));
            }
            else if (index >= 0)
            {
                var temp = recipe_components[index];
                temp.count += count;
                recipe_components[index] = temp;
            }
        }

        public void ConvertToRecipe()
        {
            componentType = ComponentType.Recipe;
            recipe_components = new List<(int component_id, decimal count)>();
        }
        public void ConvertBackToResource()
        {
            if (recipe_components.Count != 0)
            {
                var confirm = MessageBox.Show("Recipe has components, do you want to continue?", "Warning", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    componentType = ComponentType.Resource;
                    recipe_components = null;
                }
            }
            else
            {
                componentType = ComponentType.Resource;
                recipe_components = null;
            }
        }

        public enum ComponentType
        {
            Resource,
            Recipe
        }
    }
}
