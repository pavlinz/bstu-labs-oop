using System.ComponentModel.DataAnnotations;

namespace Lab05
{
    public class PassportAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string passport = value.ToString();
                if (passport.StartsWith("MP") && passport.Length == 9)
                    return true;
                else
                    this.ErrorMessage = "Некорректные паспортные данные";
            }
            return false;
        }
    }
}
