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
                Description = "Action Category",
                IsTest = true,
                Name = "Action"
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
            var result = _repository.Delete(_entity.Id);
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
                Description = "Comedy Category",
                Name = "Comedy"
            };

            _repository.Add(actionCategory);

            var categories = _repository.GetList(c => c.Name.Contains("Fiction")).ToList();
            var count = categories.Count();

            Assert.IsTrue(count == 1 && categories[0].Name == "Comedy");
        }

        [TestMethod]
        public void UpdateCategoryTest()
        {
            _entity.Name = "Fiction";
            _entity.Description = "Fiction Category";

            var resultUpdate = _repository.Update(_entity);
            var category = _repository.GetById(_entity.Id);
            var resultCompare = _entity.CompareTo(category);

            Assert.IsTrue(resultUpdate && resultCompare == 0);
        }
    }
}
