using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputTouchDelegateBinding")]
	public partial class UInputTouchDelegateBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintInputTouchDelegateBinding> InputTouchDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputTouchDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintInputTouchDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputTouchDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputTouchDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputTouchDelegateBindings = 0;
	}
}