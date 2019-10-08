using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using test_template.Models.entity;

namespace test_template.Models.function
{
    public class AccountDao
    {
        DbconnectString db = null;
        public AccountDao()
        {
            db = new DbconnectString();
        }

        public Account GetbyId(string username)
        {
            return db.Accounts.SingleOrDefault(x => x.Username == username);
        }
        public int insert(Account entity)
        {
            var check = db.Accounts.SingleOrDefault(x => x.Username == entity.Username);
            if (check == null)
            {
                entity.Permission = "User";
                entity.Active = "1";
                //  code kierm tra loi EntityValidate lỗi ràng buỗjc
                try
                {
                    db.Accounts.Add(entity);
                    db.SaveChanges();
                    return entity.ID;
                    // code của bạn
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }


            }
            else
            {
                return -1;
            }

        }
        public int login(string username, string passwork)
        {
            var resulf = db.Accounts.SingleOrDefault(x => x.Username == username);
            if (resulf == null)
            {
                return 0;
            }
            else
            {
                if (resulf.Password == passwork)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}