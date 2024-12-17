using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputAxisDelegateBinding")]
	public partial class UInputAxisDelegateBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintInputAxisDelegateBinding> InputAxisDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputAxisDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintInputAxisDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputAxisDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputAxisDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputAxisDelegateBindings = 0;
	}
}