namespace AlgorithmicChallenges.Problems.AdventOfCode.Day4.Services
{
    using System.Linq;
    using Dtos;
    using Enums;
    using FluentValidation;

    public class PassportValidator : AbstractValidator<Passport>
    {
        public PassportValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleLevelCascadeMode = CascadeMode.Stop;
            
            RuleFor(pass => pass.BirthYear)
                .NotNull()
                .GreaterThanOrEqualTo(1920)
                .LessThanOrEqualTo(2002);
            
            RuleFor(pass => pass.ExpirationYear)
                .NotNull()
                .GreaterThanOrEqualTo(2020)
                .LessThanOrEqualTo(2030);
            
            RuleFor(pass => pass.IssueYear).NotNull()
                .GreaterThanOrEqualTo(2010)
                .LessThanOrEqualTo(2020);

            RuleFor(pass => pass.Height)
                .NotNull();

            RuleFor(pass => pass.Height!.Value)
                .GreaterThanOrEqualTo(150)
                .LessThanOrEqualTo(193)
                .When(pass => pass.Height!.UnitOfLength == EUnitOfLength.Centimeter);
            
            RuleFor(pass => pass.Height!.Value)
                .GreaterThanOrEqualTo(59)
                .LessThanOrEqualTo(76)
                .When(pass => pass.Height!.UnitOfLength == EUnitOfLength.Inch);
                
            RuleFor(pass => pass.HairColor)
                .NotNull()
                .Matches("^#(?:[0-9a-fA-F]{3}){1,2}$");
            
            RuleFor(pass => pass.EyeColor).NotNull();
            
            RuleFor(pass => pass.PassportId)
                .NotNull()
                .Length(9)
                .Must(id => id.All(char.IsDigit));
        }
    }
}