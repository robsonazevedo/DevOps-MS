using App.Console.Helper;
using Domain.Entities;

namespace App.Console.View
{
    internal class ViewCategoryMenu : IViewBase<CategoryEntity>
    {
        public CategoryEntity ViewAdd()
        {
            throw new System.NotImplementedException();
        }

        public CategoryEntity ViewDelete()
        {
            throw new System.NotImplementedException();
        }

        public void ViewList()
        {
            throw new System.NotImplementedException();
        }

        public string ViewSearch()
        {
            System.Console.WriteLine(ViewMenuHelper.GetView("category"));
            System.Console.Write("NOME: ");
            return SystemHelper.GetInput();
        }

        public CategoryEntity ViewUpdate()
        {
            throw new System.NotImplementedException();
        }
    }
}
