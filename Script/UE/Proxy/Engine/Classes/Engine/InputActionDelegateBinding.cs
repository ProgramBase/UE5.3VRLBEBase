using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputActionDelegateBinding")]
	public partial class UInputActionDelegateBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintInputActionDelegateBinding> InputActionDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputActionDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintInputActionDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputActionDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputActionDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputActionDelegateBindings = 0;
	}
}