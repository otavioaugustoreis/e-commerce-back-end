using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.Patterns
{
    public interface IDeleteTest
    {
        Task Put_Delete_Return_OkResult();
        Task Put_Delete_Return_NotFound();
    }
}
