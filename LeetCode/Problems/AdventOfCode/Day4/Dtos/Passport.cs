namespace LeetCode.Problems.AdventOfCode.Day4.Dtos
{
    using Enums;

    public class Passport
    {
        public int? BirthYear { get; set; }
        
        public int? IssueYear { get; set; }
        
        public int? ExpirationYear { get; set; }
        
        public Height? Height { get; set; }
        
        public string? HairColor { get; set; }
        
        public EEyeColor? EyeColor { get; set; }
        
        public string? PassportId { get; set; }
        
        public string? CountryId { get; set; }
    }
}