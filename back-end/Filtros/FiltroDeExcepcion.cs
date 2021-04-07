namespace back_end.Filtros
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;

    public class FiltroDeExcepcion: ExceptionFilterAttribute
    {
        private readonly ILogger<FiltroDeExcepcion> _logger;
        public FiltroDeExcepcion(ILogger<FiltroDeExcepcion> logger)
        {
            this._logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
