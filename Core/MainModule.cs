using MugenMvvmToolkit;
using MugenMvvmToolkit.Interfaces.Validation;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.Modules;
using Core.Validators;

namespace Core
{
    public class PortableModule : ModuleBase
    {
        #region Constructors

        public PortableModule()
            : base(false, LoadMode.All)
        {
        }

        #endregion

        #region Overrides of ModuleBase

        /// <summary>
        ///     Loads the current module.
        /// </summary>
        protected override bool LoadInternal()
        {
            var validatorProvider = IocContainer.Get<IValidatorProvider>();
            //NOTE: Registering validator.
            validatorProvider.Register<UserValidator>();
            return true;
        }

        /// <summary>
        ///     Unloads the current module.
        /// </summary>
        protected override void UnloadInternal()
        {
        }

        #endregion
    }
}
