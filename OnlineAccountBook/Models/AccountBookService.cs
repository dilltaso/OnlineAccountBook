using OnlineAccountBook.Models.ViewModels;
using OnlineAccountBook.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace OnlineAccountBook.Models
{
    public class AccountBookService
    {
        private readonly IUnitOfWork _dbUnitOfWork;

        private readonly IRepository<AccountBookDBTable> _dbRepository;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _dbUnitOfWork = unitOfWork;

            _dbRepository = new Repository<AccountBookDBTable>(unitOfWork);
        }

        public IQueryable<AccountItemViewModel> Lookup()
        {
            var source = _dbRepository.LookupAll();

            var result = source.Select(data => new AccountItemViewModel()
            {
                Category = (data.Categoryyy == 1 ? "收入" : "支出"),
                Date = data.Dateee,
                Money = data.Amounttt,
                Description = data.Remarkkk
            });

            return result;
        }

        public void Add(AccountItemViewModel newData)
        {
            var result = new AccountBookDBTable()
            {
                Id = Guid.NewGuid(),
                Categoryyy = (newData.Category == "收入" ? 1 : 0),
                Dateee = newData.Date,
                Amounttt = (int)newData.Money,
                Remarkkk = newData.Description
            };

            _dbRepository.Create(result);
        }


        public void Save()
        {
            _dbUnitOfWork.Save();
        }
    }
}