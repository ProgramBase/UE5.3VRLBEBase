using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputModifier")]
	public partial class UInputModifier : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="CurrentValue">
		/// - The modified value returned by the previous modifier in the chain, or the base raw value if this is the first modifier in the chain.
		/// </param>
		public virtual FInputActionValue ModifyRaw(UEnhancedPlayerInput PlayerInput, FInputActionValue CurrentValue, float DeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = PlayerInput?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurrentValue?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ModifyRaw, __InBuffer, __ReturnBuffer);

				return *(FInputActionValue*)__ReturnBuffer;
			}
		}

		/// <param name="SampleValue">
		/// - The base input action value pre-modification (ranging -1 -> 1 across all applicable axes).
		/// </param>
		/// <param name="FinalValue">
		/// - The post-modification input action value for the provided SampleValue.
		/// </param>
		public virtual FLinearColor GetVisualizationColor(FInputActionValue SampleValue, FInputActionValue FinalValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SampleValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FinalValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVisualizationColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		private static uint __ModifyRaw = 0;

		private static uint __GetVisualizationColor = 0;
	}
}