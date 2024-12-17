using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputPlatformData")]
	public partial class UEnhancedInputPlatformData : UObject, IStaticClass
	{
		public TMap<UInputMappingContext, UInputMappingContext> MappingContextRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MappingContextRedirects, __ReturnBuffer);

					return *(TMap<UInputMappingContext, UInputMappingContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MappingContextRedirects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputPlatformData");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UInputMappingContext GetContextRedirect(UInputMappingContext InContext)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetContextRedirect, __InBuffer, __ReturnBuffer);

				return *(UInputMappingContext*)__ReturnBuffer;
			}
		}

		private static uint __MappingContextRedirects = 0;

		private static uint __GetContextRedirect = 0;
	}
}