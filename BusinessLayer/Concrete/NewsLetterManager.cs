using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {

        INewsLetterDal _NewsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _NewsLetterDal = newsLetterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _NewsLetterDal.Insert(newsLetter);
        }
    }
}
