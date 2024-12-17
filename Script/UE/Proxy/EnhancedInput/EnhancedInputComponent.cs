using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputComponent")]
	public partial class UEnhancedInputComponent : UInputComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FInputActionValue GetBoundActionValue(UInputAction Action)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoundActionValue, __InBuffer, __ReturnBuffer);

				return *(FInputActionValue*)__ReturnBuffer;
			}
		}

		private static uint __GetBoundActionValue = 0;
	}
}