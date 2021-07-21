﻿using DLL;
using MODEL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class BookBusiness
    {
        public BookBusiness()
        {
        }

        public List<Book> GetAll()
        {
            List<Book> books = Services.book.GetAll();
            return books;

        }
    }
}
