using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputActionInstance")]
	public partial class FInputActionInstance : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.InputActionInstance");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInputActionInstance() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInputActionInstance() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInputActionInstance A, FInputActionInstance B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInputActionInstance A, FInputActionInstance B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInputActionInstance;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UInputAction SourceAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceAction, __ReturnBuffer);

					return *(UInputAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceAction, __InBuffer);
				}
			}
		}

		public ETriggerEvent TriggerEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriggerEvent, __ReturnBuffer);

					return *(ETriggerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriggerEvent, __InBuffer);
				}
			}
		}

		public float LastTriggeredWorldTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastTriggeredWorldTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastTriggeredWorldTime, __InBuffer);
				}
			}
		}

		public TArray<UInputTrigger> Triggers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Triggers, __ReturnBuffer);

					return *(TArray<UInputTrigger>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Triggers, __InBuffer);
				}
			}
		}

		public TArray<UInputModifier> Modifiers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Modifiers, __ReturnBuffer);

					return *(TArray<UInputModifier>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Modifiers, __InBuffer);
				}
			}
		}

		public float ElapsedProcessedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ElapsedProcessedTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ElapsedProcessedTime, __InBuffer);
				}
			}
		}

		public float ElapsedTriggeredTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ElapsedTriggeredTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ElapsedTriggeredTime, __InBuffer);
				}
			}
		}

		private static uint __SourceAction = 0;

		private static uint __TriggerEvent = 0;

		private static uint __LastTriggeredWorldTime = 0;

		private static uint __Triggers = 0;

		private static uint __Modifiers = 0;

		private static uint __ElapsedProcessedTime = 0;

		private static uint __ElapsedTriggeredTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}