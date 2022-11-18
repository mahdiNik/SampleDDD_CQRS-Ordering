﻿
using CSharpFunctionalExtensions;
using MediatR;
using Ordering.Domain.AggregatesModel.OrderAggregate;
using System.Threading;
using System.Threading.Tasks;


namespace Ordering.Application.Commands
{
    public class SetAwaitingValidationOrderStatusCommand : IRequest<Result>
    {
        public int OrderNumber { get; private set; }
        public SetAwaitingValidationOrderStatusCommand(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
