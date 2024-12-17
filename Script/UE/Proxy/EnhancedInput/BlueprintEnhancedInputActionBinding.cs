using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.BlueprintEnhancedInputActionBinding")]
	public partial class FBlueprintEnhancedInputActionBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.BlueprintEnhancedInputActionBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintEnhancedInputActionBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintEnhancedInputActionBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintEnhancedInputActionBinding A, FBlueprintEnhancedInputActionBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintEnhancedInputActionBinding A, FBlueprintEnhancedInputActionBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintEnhancedInputActionBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UInputAction InputAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputAction, __ReturnBuffer);

					return *(UInputAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputAction, __InBuffer);
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

		public FName FunctionNameToBind
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionNameToBind, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionNameToBind, __InBuffer);
				}
			}
		}

		private static uint __InputAction = 0;

		private static uint __TriggerEvent = 0;

		private static uint __FunctionNameToBind = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}