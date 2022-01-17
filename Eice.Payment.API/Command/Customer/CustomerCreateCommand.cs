﻿using MediatR;

namespace Eice.Payment.API.Command.Customer
{
    public class CustomerCreateCommand : Command, IRequest<string>
    {
        public string PartnerId { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }

        public override bool IsValid()
        {
            var validationResult = new CustomerCreateCommandValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
