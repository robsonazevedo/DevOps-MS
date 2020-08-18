using Domain.Entities;

namespace App.Console.Executions
{
    internal interface IExecuteBase<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void List();

        void Search(string name);

        void Update(TEntity entity);
    }
}
