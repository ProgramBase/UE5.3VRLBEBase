using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputAxisKeyDelegateBinding")]
	public partial class UInputAxisKeyDelegateBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintInputAxisKeyDelegateBinding> InputAxisKeyDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputAxisKeyDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintInputAxisKeyDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputAxisKeyDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputAxisKeyDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputAxisKeyDelegateBindings = 0;
	}
}