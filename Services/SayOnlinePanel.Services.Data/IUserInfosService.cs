using System;
using System.Collections.Generic;
using System.Text;

namespace SayOnlinePanel.Services.Data
{
    public interface IUserInfosService
    {
        IEnumerable<T> GetAll<T>();
    }
}
