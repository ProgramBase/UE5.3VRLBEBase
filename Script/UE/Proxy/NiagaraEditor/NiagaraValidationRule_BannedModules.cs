using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraValidationRule_BannedModules")]
	public partial class UNiagaraValidationRule_BannedModules : UNiagaraValidationRule, IStaticClass
	{
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Platforms, __ReturnBuffer);

					return *(FNiagaraPlatformSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Platforms, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraScript> BannedModules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BannedModules, __ReturnBuffer);

					return *(TArray<UNiagaraScript>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BannedModules, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraValidationRule_BannedModules");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Platforms = 0;

		private static uint __BannedModules = 0;
	}
}