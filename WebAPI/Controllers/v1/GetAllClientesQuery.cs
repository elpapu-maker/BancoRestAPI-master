using MediatR;

namespace WebAPI.Controllers.v1
{
    internal class GetAllClientesQuery : IRequest<object>
    {
        public object PageNumber { get; set; }
        public object PageSize { get; set; }
        public object Nombre { get; set; }
        public object Apellido { get; set; }
    }
}