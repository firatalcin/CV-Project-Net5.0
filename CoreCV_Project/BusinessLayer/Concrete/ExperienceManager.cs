﻿using CoreCV_Project.BusinessLayer.Abstract;
using CoreCV_Project.DataAccessLayer.Abstract;
using CoreCV_Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Add(entity);
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);  
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TRemove(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
