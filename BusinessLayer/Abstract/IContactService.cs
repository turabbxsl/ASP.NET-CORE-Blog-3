using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void ContactAdd(Contact contact);
    }
}
