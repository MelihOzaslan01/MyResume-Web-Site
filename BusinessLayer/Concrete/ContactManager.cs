﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal _ContactDal;
		public ContactManager(IContactDal ContactDal)
		{
			_ContactDal = ContactDal;

		}
		public void TAdd(Contact t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Contact t)
		{
			throw new NotImplementedException();
		}

		public Contact TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			return _ContactDal.GetList();
		}

		public void TUpdate(Contact t)
		{
			throw new NotImplementedException();
		}
	}
}
