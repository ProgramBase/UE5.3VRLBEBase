using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputActionValueBinding")]
	public partial class UEnhancedInputActionValueBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintEnhancedInputActionBinding> InputActionValueBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputActionValueBindings, __ReturnBuffer);

					return *(TArray<FBlueprintEnhancedInputActionBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputActionValueBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputActionValueBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputActionValueBindings = 0;
	}
}