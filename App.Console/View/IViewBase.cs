using Domain.Entities;

namespace App.Console.View
{
    internal interface IViewBase<TEntity> where TEntity : EntityBase
    {
        TEntity ViewAdd();

        TEntity ViewDelete();

        void ViewList();

        string ViewSearch();

        TEntity ViewUpdate();
    }
}