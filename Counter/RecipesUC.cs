using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class RecipesUC : UserControl
    {
        private Profile _profile;
        private string[] _craftingRecipes;
        private string[] _craftingComponents;
        private bool _creatingNewRecipe = false;

        public RecipesUC()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
            _profile = ProfileManager.SelectedProfile;
            
            CreateRecipeButton.Enabled = _profile != null;
            SetMainControlsVisibility(_profile != null);
            SetConfirmationButtonsVisibility(false);
            if (_profile == null)
            {
                return;
            }

            ComponentsHolder.InitializeComponents();
            _craftingRecipes = ComponentsHolder.GetComponentNames(true, false);
            _craftingComponents = ComponentsHolder.GetComponentNames(ShowRecipesToggle.Checked, true);
            FillRecipesList();
        }

        private void FillRecipesList(string ifContains = null)
        {
            RecipeSelectBox.Items.Clear();
            for (int i = 0; i < _craftingRecipes.Length; i++)
            {
                if (string.IsNullOrEmpty(ifContains))
                {
                    RecipeSelectBox.Items.Add(_craftingRecipes[i]);
                    continue;
                }

                if (_craftingRecipes[i].Contains(ifContains))
                    RecipeSelectBox.Items.Add(_craftingRecipes[i]);
            }
        }

        private void FillComponentsList(string ifContains = null)
        {
            ComponentListBox.Items.Clear();
            for (int i = 0; i < _craftingComponents.Length; i++)
            {
                if (string.IsNullOrEmpty(ifContains))
                {
                    ComponentListBox.Items.Add(_craftingComponents[i]);
                    continue;
                }

                if (_craftingRecipes[i].Contains(ifContains))
                    ComponentListBox.Items.Add(_craftingComponents[i]);
            }
        }

        #region Event handlers
        private void RecipesUC_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            Hide();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            SelectedRecipeName.Enabled = true;
            SetConfirmationButtonsVisibility(true);
            SetMainControlsVisibility(false);
        }

        private void CreateRecipeButton_Click(object sender, EventArgs e)
        {
            SelectedRecipeName.Text = "";
            SelectedRecipeName.Enabled = true;
            SetConfirmationButtonsVisibility(true);
            SetMainControlsVisibility(false);
            _creatingNewRecipe = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MBConfirmDeleteText.Text, "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void RecipeNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComponentEnterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmNameButton_Click(object sender, EventArgs e)
        {
            SelectedRecipeName.Enabled = false;
            SetConfirmationButtonsVisibility(false);
            SetMainControlsVisibility(true);

            if (SelectedRecipeName.Text == "")
                return;

            if (_creatingNewRecipe)
            {
                ComponentsHolder.CreateNewRecipe(SelectedRecipeName.Text.ToLower());
                FillRecipesList();
                _craftingComponents = ComponentsHolder.GetComponentNames(ShowRecipesToggle.Checked, true);
                FillComponentsList(ComponentEnterBox.Text);
            }
            else //rename
            {

            }

            SelectedRecipeName.Text = "";
            _creatingNewRecipe = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SetConfirmationButtonsVisibility(false);
            SetMainControlsVisibility(true);

            if (_creatingNewRecipe)
            {
                RecipeNameBox.Text = "";
            }

            _creatingNewRecipe = false;
        }

        private void SetConfirmationButtonsVisibility(bool visible)
        {
            ConfirmNameButton.Visible = visible;
            CreateRecipeButton.Visible = !visible;
            CancelButton.Visible = visible;
            RenameButton.Visible = !visible;
        }

        private void SetMainControlsVisibility(bool visible)
        {
            RenameButton.Enabled = visible;
            CalculateButton.Enabled = visible;
            DeleteButton.Enabled = visible;
            dataGridView1.Enabled = visible;
            RecipeSelectBox.Enabled = visible;
            RecipeNameBox.Enabled = visible;
            ComponentEnterBox.Enabled = visible;
            ComponentListBox.Enabled = visible;
            AddComponentButton.Enabled = visible;
            ShowRecipesToggle.Enabled = visible;
        }
        #endregion

        private void ShowRecipesToggle_CheckedChanged(object sender, EventArgs e)
        {
            _craftingComponents = ComponentsHolder.GetComponentNames(ShowRecipesToggle.Checked, true);
            FillComponentsList(ComponentEnterBox.Text);
        }
    }
}
