using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputKeyDelegateBinding")]
	public partial class UInputKeyDelegateBinding : UInputDelegateBinding, IStaticClass
	{
		public TArray<FBlueprintInputKeyDelegateBinding> InputKeyDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputKeyDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintInputKeyDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputKeyDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputKeyDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputKeyDelegateBindings = 0;
	}
}