using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public static class CONST
  {
    #region "Pancake House Menu"
    public const string P_1_NAME = "K&B's Pancake Breakfast";
    public const string P_1_DESC = "Pancakes with scrambled eggs, and toast";
    public const double P_1_PRICE = 2.99;
    public const bool P_1_VEG = true;

    public const string P_2_NAME = "Regular Pancake Breakfast";
    public const string P_2_DESC = "Pancakes with fried eggs, sausage";
    public const double P_2_PRICE = 2.99;
    public const bool P_2_VEG = false;

    public const string P_3_NAME = "Blueberry Pancakes";
    public const string P_3_DESC = "Pancakes made with fresh blueberries";
    public const double P_3_PRICE = 3.49;
    public const bool P_3_VEG = true;

    public const string P_4_NAME = "Waffles";
    public const string P_4_DESC = "Waffles, with your choice of blueberries or strawberries";
    public const double P_4_PRICE = 3.59;
    public const bool P_4_VEG = true;
    #endregion 

    #region "Dinner Menu"
    public const string D_1_NAME = "Vegetarian BLT";
    public const string D_1_DESC = "(Fakin') Bacon with Lettuce & tomato on whole wheat";
    public const double D_1_PRICE = 2.99;
    public const bool D_1_VEG = true;

    public const string D_2_NAME = "BLT";
    public const string D_2_DESC = "Bacon with Lettuce & tomato on whole wheat";
    public const double D_2_PRICE = 2.99;
    public const bool D_2_VEG = false;

    public const string D_3_NAME = "Soup of the day";
    public const string D_3_DESC = "Soup of the day, with a side of potato salad";
    public const double D_3_PRICE = 3.29;
    public const bool D_3_VEG = false;

    public const string D_4_NAME = "Hotdog";
    public const string D_4_DESC = "A hot dog, with saurkant, relish, onions, topped with cheese";
    public const double D_4_PRICE = 3.05;
    public const bool D_4_VEG = false;
    #endregion

    #region "Cafe Menu"
    public const string C_1_NAME = "Veggie Burger and Air Fries";
    public const string C_1_DESC = "Veggie burger on a whole wheat bun, lettuce, tomato, and fries";
    public const double C_1_PRICE = 3.99;
    public const bool C_1_VEG = true;

    public const string C_2_NAME = "Soup of the day";
    public const string C_2_DESC = "A cup of the soup of the day, with a side salad";
    public const double C_2_PRICE = 3.69;
    public const bool C_2_VEG = false;

    public const string C_3_NAME = "Burrito";
    public const string C_3_DESC = "A large burrito, with whole pinto beans, salsa, guacamole";
    public const double C_3_PRICE = 4.29;
    public const bool C_3_VEG = true;
    #endregion

    #region "Dessert Menu"
    public const string S_1_NAME = "Apple Pie";
    public const string S_1_DESC = "Apple pie with a flakey crust, topped with vanilla icecream";
    public const double S_1_PRICE = 1.59;
    public const bool S_1_VEG = true;

    public const string S_2_NAME = "Cheesecake";
    public const string S_2_DESC = "Creamy New York cheesecake, with a chocolate graham crust";
    public const double S_2_PRICE = 1.99;
    public const bool S_2_VEG = true;

    public const string S_3_NAME = "Sorbet";
    public const string S_3_DESC = "A scoop of rasberry and a scoop of line";
    public const double S_3_PRICE = 1.89;
    public const bool S_3_VEG = true;
    #endregion

    #region "Menus"
    public const string M_0_NAME = "ALL MENUS";
    public const string M_0_DESC = "All menus combined";

    public const string M_1_NAME = "PANCAKE HOUSE MENU";
    public const string M_1_DESC = "Breakfast";
  
    public const string M_2_NAME = "DINER MENU";
    public const string M_2_DESC = "Lunch";

    public const string M_3_NAME = "CAFE MENU";
    public const string M_3_DESC = "Dinner";

    public const string M_4_NAME = "DESSERT MENU";
    public const string M_4_DESC = "Dessert of course!";
    #endregion

    public const string LINE_SEPARATOR = "------------------------";
    public const string IsVeg = "(v)";
    public const string NtVeg = "";
  }
}
