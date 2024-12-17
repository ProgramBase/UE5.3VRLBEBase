using Script.CoreUObject;
using Script.Engine;
using Script.InputCore;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedPlayerInput")]
	public partial class UEnhancedPlayerInput : UPlayerInput, IStaticClass
	{
		public TMap<UInputAction, FKeyConsumptionOptions> KeyConsumptionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeyConsumptionData, __ReturnBuffer);

					return *(TMap<UInputAction, FKeyConsumptionOptions>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeyConsumptionData, __InBuffer);
				}
			}
		}

		public TMap<UInputMappingContext, int> AppliedInputContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedInputContexts, __ReturnBuffer);

					return *(TMap<UInputMappingContext, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedInputContexts, __InBuffer);
				}
			}
		}

		public TArray<FEnhancedActionKeyMapping> EnhancedActionMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnhancedActionMappings, __ReturnBuffer);

					return *(TArray<FEnhancedActionKeyMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnhancedActionMappings, __InBuffer);
				}
			}
		}

		public TMap<UInputAction, FInputActionInstance> ActionInstanceData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActionInstanceData, __ReturnBuffer);

					return *(TMap<UInputAction, FInputActionInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActionInstanceData, __InBuffer);
				}
			}
		}

		public TMap<FKey, FVector> KeysPressedThisTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeysPressedThisTick, __ReturnBuffer);

					return *(TMap<FKey, FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeysPressedThisTick, __InBuffer);
				}
			}
		}

		public TMap<UInputAction, FInjectedInputArray> InputsInjectedThisTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputsInjectedThisTick, __ReturnBuffer);

					return *(TMap<UInputAction, FInjectedInputArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputsInjectedThisTick, __InBuffer);
				}
			}
		}

		public TSet<UInputAction> LastInjectedActions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastInjectedActions, __ReturnBuffer);

					return *(TSet<UInputAction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastInjectedActions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedPlayerInput");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __KeyConsumptionData = 0;

		private static uint __AppliedInputContexts = 0;

		private static uint __EnhancedActionMappings = 0;

		private static uint __ActionInstanceData = 0;

		private static uint __KeysPressedThisTick = 0;

		private static uint __InputsInjectedThisTick = 0;

		private static uint __LastInjectedActions = 0;
	}
}