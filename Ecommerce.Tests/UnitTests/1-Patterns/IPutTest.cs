using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.Patterns
{
    public interface IPutTest
    {
        Task Put_Update_Return_OkResult();
        Task Put_Update_Return_BadRequest();
    }
}
