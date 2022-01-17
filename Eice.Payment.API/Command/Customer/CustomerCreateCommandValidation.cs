﻿using FluentValidation;

namespace Eice.Payment.API.Command.Customer
{
    public class CustomerCreateCommandValidation : AbstractValidator<CustomerCreateCommand>
    {
        public CustomerCreateCommandValidation()
        {
            RuleFor(client => client.Cpf).Length(11);
            RuleFor(client => client.PartnerId).NotEmpty();
            //não pode mesmo cpf para mesmo partner
            //pode mesmo cpf diferentes partners
            //cpf only numbers
        }
    }
}
