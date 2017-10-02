using System;
using System.ComponentModel;

namespace CRUD.Data
{
    public abstract class ViewModel : IDataErrorInfo
    {
        public string this[string columnName] => throw new NotImplementedException();

        public string Error => throw new NotImplementedException();
    }
}
