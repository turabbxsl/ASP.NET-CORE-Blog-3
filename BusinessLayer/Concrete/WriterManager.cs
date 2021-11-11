using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {


        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _writerDal.GetByID(id);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterByID(int id)
        {
            return _writerDal.GetListAll(x=>x.WriterID == id);
        }

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public void WriterDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void WriterUpdate(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
