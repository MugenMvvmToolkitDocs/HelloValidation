using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Core.Models;
using MugenMvvmToolkit.Infrastructure.Validation;

namespace Core.Validators
{
    public class UserValidator : ValidatorBase<User>
    {
        #region Overrides of ValidatorBase

        protected override Task<IDictionary<string, IEnumerable>> ValidateInternalAsync(string propertyName, CancellationToken token)
        {
            if (!Context.ValidationMetadata.Contains(ValidationConstants.IsNeedToValidate))
                return EmptyResult;

            if (propertyName == null || propertyName == nameof(Instance.Firstname))
            {
                if (string.IsNullOrEmpty(Instance.Firstname))
                    return FromResult(new Dictionary<string, IEnumerable>
                                {
                                  { nameof(Instance.Firstname), "First name cannot be empty!" }
                                });
                if (!char.IsUpper(Instance.Firstname[0]))
                {
                    return FromResult(new Dictionary<string, IEnumerable>
                                {
                                  { nameof(Instance.Firstname), "First letter of first name have to be in upper case!" }
                                });
                }
            }
            if (propertyName == null || propertyName == nameof(Instance.Lastname))
            {
                if (string.IsNullOrEmpty(Instance.Lastname))
                    return FromResult(new Dictionary<string, IEnumerable>
                                {
                                  { nameof(Instance.Lastname), "Last name cannot be empty!" }
                                });
                if (!char.IsUpper(Instance.Lastname[0]))
                {
                    return FromResult(new Dictionary<string, IEnumerable>
                                {
                                  { nameof(Instance.Lastname), "First letter of last name have to be in upper case!" }
                                });
                }
            }
            return EmptyResult;
        }

        protected override Task<IDictionary<string, IEnumerable>> ValidateInternalAsync(CancellationToken token)
        {
            return ValidateInternalAsync(null, token);
        }

        #endregion
    }
}