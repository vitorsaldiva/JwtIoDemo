using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JoseRtDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var secret = Encoding.ASCII.GetBytes("n80iIO5zek1Ss6aIylMM5120UcB3G5R3YGrSC+fiIW9QgjBqyH+XnW5M1LooXBKDV6cIE7AvgoM4q8CDoW5mb5I3OEgioh/dHbRSKkfaTgNYT7Q/2g2+IP+sMR2/E/wA5mQo8STKYLWIKvb83Vc8Xly8K1K5JpWEeBdIdnABHQm3UUTisl3fju7+tq8XwUKob9PBA+iqRr/Po3gNgepEhwzsRIsTWqv+3J1ju2/lbLbUoAadQBohDQuEEw7l0gwEui+iK323lRUnwiZKRotQ6TbBOOHjp0byyjd/jkacGAqRXwA/Q0E5HQvwdn3z18aANCnYJJkrIBPpsGBGNwbPig==");
            string payload = @"{""iss"": ""4c17a3c1 - cfee - 445b - a9b3 - 2a9fe4c44b63""},{""access"",""cardPayments.authorize""},{""exp"", 1514772000}";
            string token = JoseRT.Jwt.Encode(payload, JwsAlgorithm.HS256, secretKey);

        }
    }
}
