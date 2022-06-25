using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPICodeInside.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("/average")]
        public int Average([FromQuery] int[] nums)
        {
            int total = 0;
            foreach (var num in nums)
            {
                total += num;
            }
            return total / nums.Count();
        }
        [HttpGet("/smallest")]
        public int Smallest([FromQuery] int[] nums)
        {
            int smallest = nums[0];
            foreach (var num in nums)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
        }
        [HttpGet("/largest")]
        public int Largest([FromQuery] int[] nums)
        {
            int largest = nums[0];
            foreach (var num in nums)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            return largest;
        }
    }
}
