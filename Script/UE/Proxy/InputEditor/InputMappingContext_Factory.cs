using Script.CoreUObject;
using Script.UnrealEd;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.InputMappingContext_Factory")]
	public partial class UInputMappingContext_Factory : UFactory, IStaticClass
	{
		public TSubclassOf<UInputMappingContext> InputMappingContextClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputMappingContextClass, __ReturnBuffer);

					return *(TSubclassOf<UInputMappingContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputMappingContextClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.InputMappingContext_Factory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputMappingContextClass = 0;
	}
}