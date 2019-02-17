using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using AsianCuisine.Model;
using BLToolkit.Data;

namespace AsianCuisine
{
    /// <summary>
    /// Логика взаимодействия для DishTypes.xaml
    /// </summary>
    public partial class DishTypes : Page
    {
        public DishTypes()
        {
            InitializeComponent();
            List<DishType> dishTypes = GetDishTypes();
            foreach (var dishType in dishTypes)
            {
                Button button = new Button();
                button.Padding = new Thickness(0, 15, 0, 15);
                button.Content = dishType.Name;
                DishTypeList.Items.Add(button);
            }
        }

        private List<DishType> GetDishTypes()
        {
            using (DbManager db = new DbManager())
            {
                db.SetSpCommand("GetDishTypes");
                List<DishType> dishTypes = db.ExecuteList<DishType>();
                return dishTypes;
            }
        }
    }
}
