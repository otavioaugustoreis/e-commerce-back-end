using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.Patterns
{
    public interface IDeleteTest
    {
        Task Delete_Return_OkResult();
        Task Delete_Return_NotFound();
    }
}
