﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;

        
    }
}
