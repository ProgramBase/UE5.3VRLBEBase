using Script.CoreUObject;
using Script.UnrealEd;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.InputAction_Factory")]
	public partial class UInputAction_Factory : UFactory, IStaticClass
	{
		public TSubclassOf<UInputAction> InputActionClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputActionClass, __ReturnBuffer);

					return *(TSubclassOf<UInputAction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputActionClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.InputAction_Factory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputActionClass = 0;
	}
}