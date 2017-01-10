using MugenMvvmToolkit.Models;

namespace Core
{
    public static class ValidationConstants
    {
        public static readonly DataConstant<string> IsNeedToValidate = DataConstant.Create(() => IsNeedToValidate, true);
    }
}