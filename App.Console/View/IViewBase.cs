using Domain.Entities;

namespace App.Console.View
{
    internal interface IViewBase<out TEntity> where TEntity : EntityBase
    {
        TEntity ViewAdd();

        TEntity ViewDelete();

        void ViewList();

        string ViewSearch();

        TEntity ViewUpdate();
    }
}