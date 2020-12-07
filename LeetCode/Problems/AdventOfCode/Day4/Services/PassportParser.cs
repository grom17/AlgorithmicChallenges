namespace LeetCode.Problems.AdventOfCode.Day4.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Dtos;
    using Enums;

    public class PassportParser
    {
        public IEnumerable<Passport> Parse(string input)
        {
            var unParsedPassports = input.Split(new[] { Environment.NewLine + Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            return unParsedPassports.Select(unParsedPassport => unParsedPassport
                    .Replace(Environment.NewLine, " ")
                    .Split(' '))
                .Select(fields => new Passport
                {
                    BirthYear = GetBirthYear(fields),
                    ExpirationYear = GetExpirationYear(fields),
                    IssueYear = GetIssueYear(fields),
                    Height = GetHeight(fields),
                    CountryId = GetCountryId(fields),
                    EyeColor = GetEyeColor(fields),
                    HairColor = GetHairColor(fields),
                    PassportId = GetPassportId(fields)
                })
                .ToList();
        }

        private string? GetPassportId(string[] fields)
        {
            return GetValueByKey(fields, "pid");
        }

        private string? GetHairColor(string[] fields)
        {
            return GetValueByKey(fields, "hcl");
        }

        private EEyeColor? GetEyeColor(string[] fields)
        {
            var strValue = GetValueByKey(fields, "ecl");

            return strValue switch {
                "amb" => EEyeColor.Amber,
                "blu" => EEyeColor.Blue,
                "brn" => EEyeColor.Brown,
                "gry" => EEyeColor.Green,
                "grn" => EEyeColor.Grey,
                "hzl" => EEyeColor.Hazel,
                "oth" => EEyeColor.Others,
                _ => null
            };
        }

        private string? GetCountryId(string[] fields)
        {
            return GetValueByKey(fields, "cid");
        }

        private Height? GetHeight(string[] fields)
        {
            var strValue = GetValueByKey(fields, "hgt");

            var value = new string(strValue?.Where(char.IsDigit).ToArray());

            var height = new Height
            {
                Value = GetIntValue(value)
            };
            
            var unitOfLengthStr = strValue?.Replace(value, string.Empty);
            
            height.UnitOfLength = unitOfLengthStr switch {
                "cm" => EUnitOfLength.Centimeter,
                "in" => EUnitOfLength.Inch,
                _ => null
            };

            if (height.Value is null || height.UnitOfLength is null)
            {
                return null;
            }

            return height;
        }

        private int? GetBirthYear(string[] fields)
        {
            return GetIntValueByKey(fields, "byr");
        }
        
        private int? GetExpirationYear(string[] fields)
        {
            return GetIntValueByKey(fields, "eyr");
        }
        
        private int? GetIssueYear(string[] fields)
        {
            return GetIntValueByKey(fields, "iyr");
        }

        private int? GetIntValueByKey(string[] fields, string key)
        {
            var strValue = GetValueByKey(fields, key) ?? string.Empty;

            return GetIntValue(strValue);
        }

        private int? GetIntValue(string value)
        {
            if (int.TryParse(value, out var intValue))
            {
                return intValue;
            }

            return null;
        }

        private string? GetValueByKey(string[] fields, string key)
        {
            return fields.SingleOrDefault(f => f.StartsWith(key))?
                .Replace($"{key}:", string.Empty);
        }
    }
}