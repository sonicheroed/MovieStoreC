using FluentValidation;
using MovieStoreC.Models.Requests;

namespace MovieStoreC.Validator
{
        public class TestValidator : AbstractValidator<AddMovieRequest>
        {
            public TestValidator()
            {
                RuleFor(x => x.Year).GreaterThan(1900).LessThan(2030).NotNull().NotEmpty();
                RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(1).MaximumLength(250);
                //RuleFor(x => x.).NotNull().GreaterThan(DateTime.MaxValue);
            }


        }
}
