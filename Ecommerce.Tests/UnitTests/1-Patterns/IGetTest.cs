using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.Patterns
{
    public interface IGetTest<T>
    {
        Task GetById_Return_OkResult();
        Task GetById_Return_NotFound();
        Task GetById_Return_BadRequest();
        Task GetAll_Return_ListOfProdutoDTO();
        Task GetAll_Return_BadRequestResult();
    }
}
