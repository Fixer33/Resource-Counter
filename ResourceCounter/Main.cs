using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

//Made by Fixer33
//https://github.com/Fixer33

namespace ResourceCounter
{
    //Made by Fixer33
    //https://github.com/Fixer33

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Game current_game;

        private string path_to_game_file = null;

        private const string Extension = "gameprof";

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current_game != null) SaveCurrentGame();
            current_game = new Game();
        }

        private void SaveCurrentGame()
        {
            if (current_game == null) return;
            if (string.IsNullOrEmpty(path_to_game_file))
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.DefaultExt = Extension;
                sd.AddExtension = true;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    path_to_game_file = sd.FileName;
                }
                else
                {
                    return;
                }
            }
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Game));
            if (File.Exists(path_to_game_file)) File.Delete(path_to_game_file);
            FileStream fs = new FileStream(path_to_game_file, FileMode.CreateNew);
            js.WriteObject(fs, current_game);
            fs.Close();
        }
        private void LoadGameFromFile()
        {
            OpenFileDialog od = new OpenFileDialog();
            od.DefaultExt = Extension;
            if (od.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path_to_game_file = od.FileName;
                    FileStream fs = new FileStream(path_to_game_file, FileMode.Open);
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Game));
                    fs.Position = 0;
                    current_game = (Game)js.ReadObject(fs);
                    for (int i = 0; i < current_game.all_components.Count; i++)
                    {
                        current_game.all_components[i].game_to_attach = current_game;
                    }
                    fs.Close();
                    label1.Text = current_game.game_name;
                }
                catch
                {
                    MessageBox.Show("Wrong file");
                }
                RefillRecipeList();
            }
        }

        private void SetGameName_but_Click(object sender, EventArgs e)
        {
            //Made by Fixer33
            //https://github.com/Fixer33

            //Save current game if active
            if (current_game != null) SaveCurrentGame();

            //If no game selected, create new
            if (current_game == null) NewGameToolStripMenuItem_Click(newGameToolStripMenuItem, new EventArgs());

            //Enter name of new game or dismiss
            TextInputForm ti = new TextInputForm();
            if (ti.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ti.Result;
                current_game.SetGameName(ti.Result);

                listBox1.Enabled = true;
                listBox2.Enabled = true;
                listBox3.Enabled = true;
                calc_resources_but.Enabled = true;
                add_resource_but.Enabled = true;
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;
                add_to_recipe_button.Enabled = true;
            }
        }

        private void RefillRecipeList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.Items.Clear();
            foreach (Component component in current_game.all_components)
            {
                comboBox1.Items.Add(component.name);
                if (component.componentType == Component.ComponentType.Recipe)
                {
                    listBox1.Items.Add(component.name);
                }
                if (component.componentType == Component.ComponentType.Resource)
                {
                    listBox2.Items.Add(component.name);
                }
            }
        }

        private void Add_resource_but_Click(object sender, EventArgs e)
        {
            TextInputForm ti = new TextInputForm();
            if (ti.ShowDialog() == DialogResult.OK)
            {
                Component comp = new Component(ti.Result, current_game);
                current_game.all_components.Add(comp);
                RefillRecipeList();
            }
        }

        private void ListBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0) return;

            current_game.FindComponentByName(listBox2.SelectedItem.ToString()).ConvertToRecipe();
            RefillRecipeList();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            current_game.FindComponentByName(listBox1.SelectedItem.ToString()).ConvertBackToResource();
            RefillRecipeList();
        }

        private void Add_to_recipe_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || comboBox1.SelectedIndex < 0 || numericUpDown1.Value == 0) return;

            Component comp = current_game.FindComponentByName(listBox1.SelectedItem.ToString());
            Component comp_to_add = current_game.FindComponentByName(comboBox1.SelectedItem.ToString());
            decimal count = numericUpDown1.Value;

            comp.AddRecipeComponent(comp_to_add, count);
            listBox1.ClearSelected();
        }

        private void FillListBox3WithComponents(List<(int component_id, decimal count)> component_list)
        {
            listBox3.Items.Clear();
            foreach (var item in component_list)
            {
                listBox3.Items.Add(current_game[item.component_id].name + " =-= " + item.count);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            Component comp = current_game.FindComponentByName(listBox1.SelectedItem.ToString());
            FillListBox3WithComponents(comp.recipe_components);
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGameFromFile();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (current_game == null) return;
            SaveCurrentGame();
        }

        private void Calc_resources_but_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("No recipe selected!");
                return;
            }

            var res = current_game.FindComponentByName(listBox1.SelectedItem.ToString()).CalculateResources();
            FillListBox3WithComponents(res);
        }
    }
}
