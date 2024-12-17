using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraValidationRuleSet")]
	public partial class UNiagaraValidationRuleSet : UObject, IStaticClass
	{
		public TArray<UNiagaraValidationRule> ValidationRules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRules, __ReturnBuffer);

					return *(TArray<UNiagaraValidationRule>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRules, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraValidationRuleSet");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ValidationRules = 0;
	}
}