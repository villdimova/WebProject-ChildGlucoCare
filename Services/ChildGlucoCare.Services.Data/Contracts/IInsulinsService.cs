namespace ChildGlucoCare.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IInsulinsService
    {
        IEnumerable<T> GetAll<T>();
    }
}
