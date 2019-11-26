## Description
This program is made to make calculating resources (items) count to craft a recipe easilier.
There are 2 types of crafting components: Recipies and Resources
	# Resources - are simple uncraftable items that you can collect in world (for example). 
		Example: Common resources in games - Wood, Stone, Iron ore, Copper ore and etc.

	# Recipies - are craftable components of game. You can compute resource count to craft them with this program
		Example: Common recipies in games: Planks (made of wood), Iron (made by melting iron ore).

# You can add recipies in craft of other recipies and program will calculate everything recursively
	Example: You have added Wood(Resource), Iron ore(Resource), Iron(Recipe, made of 3 Iron ore). 
	Then you added Hammer recipe (made of 2 Wood and 2 Iron). 
	Calculation will give you needed resources: 2 Wood, 6 Iron ore

## Installation
If you don't want to change anything just use ResourceCounter.exe from ResourceCounter\bin\Debug directory
If you want to change something just open .sln file with VisualStudio (2017 or above)

## Important
This is alpha version and there are a lot of bugs. Try to use program carefully and not to add same resources and etc.

### !!! Don't make recursive recipies!!!

## Usage 
1. Open ResourceCounter.exe
2. Create new game or open already exising
3. If game is new add a name
4. Add resources with "Add resource" button
	To add recipe add resource with name of recipe and double click on it's name in resource list
5. Select recipe in recipe list, select needed component (Can be recipe or resource) in "Add to recipe" button, select count of component and click on "Add to recipe" button
	You can add more components of any type just by adding missing count of component again
	To remove resource from recipe fill in the count window negative value
6. Select recipe and click "Calculate resources" button to get needed resource count

###

# As a result of usage, you can easily calculate resources count for recipe

### Publication
Don't re-upload the solution.
But feel free to share a link with your friends and gaming comrads