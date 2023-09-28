using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class PortfolioManager : IPortfolioService
	{
		IPortfolioDal _PortfolioDal;

		public PortfolioManager(IPortfolioDal PortfolioDal)
		{
			_PortfolioDal = PortfolioDal;
		}

		public void TAdd(Portfolio t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Portfolio t)
		{
			throw new NotImplementedException();
		}

		public Portfolio TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Portfolio> TGetList()
		{
			return _PortfolioDal.GetList();
		}

		public void TUpdate(Portfolio t)
		{
			throw new NotImplementedException();
		}
	}
}
