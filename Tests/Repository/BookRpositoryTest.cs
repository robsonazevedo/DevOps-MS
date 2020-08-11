using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Repositories;
using System.Linq;
using Tests.Helper;

namespace Tests.Repository
{
    [TestClass]
    public class BookRepositoryTest
    {
        public readonly BookEntity _entity;

        public readonly BookRepository _repository;

        public BookRepositoryTest()
        {
            _repository = new BookRepository();
            _entity = new BookEntity
            {
               Name = "Aprenda a Programar em C#",
               PagesNumber = 8000,
               Year = 2020
            };
        }

        [TestMethod]
        public void AddBookTest()
        {
            _repository.Add(_entity);
        }

        [TestMethod]
        public void DataTest()
        {
            var book = _repository.GetById(_entity.Id);
            var result = HelperTest.CheckProperties(book);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeleteBookTest()
        {
            var result = _repository.Delete(_entity.Id);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetByIdBookTest()
        {
            var Book = _repository.GetById(_entity.Id);

            var result = _entity.CompareTo(Book);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void GetListBookTest()
        {
            var actionBook = new BookEntity
            {
                Name = "Aprenda a Programar em F#",
                PagesNumber = 10000,
                Year = 2019
            };

            _repository.Add(actionBook);

            var categories = _repository.GetList(c => c.Name.Contains("F#")).ToList();
            var count = categories.Count();

            Assert.IsTrue(count == 1);
        }

        [TestMethod]
        public void UpdateBookTest()
        {
            _entity.Name = "Aprenda a Programar em C++";
            _entity.Year = 2018;

            var resultUpdate = _repository.Update(_entity);
            var book = _repository.GetById(_entity.Id);
            var resultCompare = _entity.CompareTo(book);

            Assert.IsTrue(resultUpdate && resultCompare == 0);
        }
    }
}
