namespace AlgorithmicChallenges.Problems.LeetCode.Easy.DefangingIpAddress
{
    /// <summary>
    ///    Given a valid (IPv4) IP address, return a defanged version of that IP address.
    ///    A defanged IP address replaces every period "." with "[.]".
    ///    https://leetcode.com/problems/defanging-an-ip-address/
    /// </summary>
    public static class Solution
    {
        public static string Run(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}