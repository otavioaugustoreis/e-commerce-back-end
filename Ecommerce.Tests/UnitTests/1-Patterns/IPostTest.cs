using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.Patterns
{
    public interface IPostTest
    {
        Task Post_Return_CreatedStatusCode();
        Task Post_Return_BadRequest();
    }
}
