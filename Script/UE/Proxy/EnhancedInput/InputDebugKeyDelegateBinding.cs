using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputDebugKeyDelegateBinding")]
	public partial class UInputDebugKeyDelegateBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintInputDebugKeyDelegateBinding> InputDebugKeyDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputDebugKeyDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintInputDebugKeyDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputDebugKeyDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputDebugKeyDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputDebugKeyDelegateBindings = 0;
	}
}