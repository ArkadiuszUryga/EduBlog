using EduZbieracz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduZbieracz.Application.Contracts.Presistence
{
    public interface IWebinaryRepository
        :IAsyncRepository<Webinary>
    {
    }
}
