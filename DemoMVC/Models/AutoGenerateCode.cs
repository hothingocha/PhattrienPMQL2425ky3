using System.Text.RegularExpressions;

namespace DemoMVC.Models
{
    public class AutoGenerateCode
    {
        public string GenerateCode(string lastId)
        {
            if (Regex.IsMatch(lastId, @"^PS\d{3}$"))
            {
                int number = int.Parse(lastId.Substring(2)); // Tách số từ PSxxx
                return "PS" + (number + 1).ToString("D3");    // Tăng +1 và format về PSxxx
            }

            // Nếu không đúng định dạng hoặc rỗng, trả về mã đầu tiên
            return "PS001";
        }
    }
}

