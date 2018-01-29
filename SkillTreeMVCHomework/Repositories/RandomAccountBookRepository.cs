﻿using SkillTreeMVCHomework.Enum;
using SkillTreeMVCHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeMVCHomework.Repositories
{
    public class RandomAccountBookRepository<T> : IRepository<AccountBook> where T : class
    {
        public IQueryable<AccountBook> GetAll()
        {
            Random random = new Random(0);
            DateTime createDate = DateTime.Now;
            IQueryable<AccountBook> accountBooks = Enumerable.Repeat(new AccountBook(), 100)
                .Select(a =>
                {
                    createDate = createDate.AddDays(random.Next(0, 3));
                    return new AccountBook()
                    {
                        Amounttt = random.Next(1, 20) * 100,
                        Dateee = createDate,
                        Categoryyy = random.Next(0, 2)
                    };
                }).AsQueryable();

            return accountBooks;
        }
    }
}