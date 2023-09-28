using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ExperienceManager : IExperienceService
	{
		IExperienceDal ExperienceDal;

		public ExperienceManager(IExperienceDal experienceDal)
		{
			ExperienceDal = experienceDal;
		}

		public void TAdd(Experience t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Experience t)
		{
			throw new NotImplementedException();
		}

		public Experience TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Experience> TGetList()
		{
			return ExperienceDal.GetList();
		}

		public void TUpdate(Experience t)
		{
			throw new NotImplementedException();
		}
	}
}
