using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Repositories;
using System.Linq;
using Tests.Helper;

namespace Tests.Repository
{
    [TestClass]
    public class CategoryRepositoryTest
    {
        public readonly CategoryEntity _entity;

        public readonly CategoryRepository _repository;

        public CategoryRepositoryTest()
        {
            _repository = new CategoryRepository();
            _entity = new CategoryEntity
            {
                Description = "Livors de Ação",
                IsTest = true,
                Name = "Ação"
            };
        }

        [TestMethod]
        public void AddCategoryTest()
        {
            _repository.Add(_entity);
        }


        [TestMethod]
        public void DataTest()
        {
            var category = _repository.GetById(_entity.Id);
            var result = HelperTest.CheckProperties(category);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeleteCategoryTest()
        {
            var result = _repository.Delete(_entity);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetByIdCategoryTest()
        {
            var category = _repository.GetById(_entity.Id);

            var result = _entity.CompareTo(category);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void GetListCategoryTest()
        {
            var actionCategory = new CategoryEntity
            {
                Description = "Livros de Comédia",
                Name = "Comédio"
            };

            _repository.Add(actionCategory);

            var categories = _repository.GetList(c => c.Name.Contains("Ficção")).ToList();
            var count = categories.Count();

            Assert.IsTrue(count == 1 && categories[0].Name == "Comédia");
        }

        [TestMethod]
        public void UpdateCategoryTest()
        {
            _entity.Name = "Ficção";
            _entity.Description = "Livros de Ficção";

            var resultUpdate = _repository.Update(_entity);
            var category = _repository.GetById(_entity.Id);
            var resultCompare = _entity.CompareTo(category);

            Assert.IsTrue(resultUpdate && resultCompare == 0);
        }
    }
}
