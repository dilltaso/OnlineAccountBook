using OnlineAccountBook.Models.ViewModels;
using OnlineAccountBook.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAccountBook.Models
{
    public class AccountBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        //private readonly IRepository<AccountBookDBTable> _accountBookDBA;  //Repository 部分尚未完成, 無法正確抓取資料庫data, 先註解之

        private AccountBookDBEntities _db;        

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            //_accountBookDBA = new Repository<AccountBookDBTable>(unitOfWork);
            _db = new AccountBookDBEntities();
        }

        public IEnumerable<AccountItemViewModels> Lookup()
        {
            //var source = _accountBookDBA.LookupAll();   //Repository 部分尚未完成, 無法正確抓取資料庫data, 先註解之

            var source = _db.AccountBook;
            var result = source.Select(data => new AccountItemViewModels()
            {
                Category = (data.Categoryyy ==0 ? "收入":"支出"),
                Date = data.Dateee,
                Money = data.Amounttt,
                Description = data.Remarkkk
            }).ToList();

            return result;
        }

        public void Add(AccountItemViewModels newData)
        {
            //var result = new AccountBookDBTable()   //Repository 部分尚未完成, 無法正確抓取資料庫data, 先註解之
            //{
            //    Categoryyy = (newData.Category == "收入"? 0:1),
            //    Dateee = newData.Date,
            //    Amounttt = (int)newData.Money,
            //    Remarkkk = newData.Description
            //};

            //_accountBookDBA.Create(result);
        }


        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}