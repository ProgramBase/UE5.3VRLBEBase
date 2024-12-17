using Script.CoreUObject;
using Script.Library;
using Script.InputCore;
using Script.Engine;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.PlayerMappableKeyQueryOptions")]
	public partial class FPlayerMappableKeyQueryOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.PlayerMappableKeyQueryOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlayerMappableKeyQueryOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlayerMappableKeyQueryOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlayerMappableKeyQueryOptions A, FPlayerMappableKeyQueryOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlayerMappableKeyQueryOptions A, FPlayerMappableKeyQueryOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlayerMappableKeyQueryOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName MappingName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MappingName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MappingName, __InBuffer);
				}
			}
		}

		public FKey KeyToMatch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyToMatch, __ReturnBuffer);

					return *(FKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyToMatch, __InBuffer);
				}
			}
		}

		public EPlayerMappableKeySlot SlotToMatch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SlotToMatch, __ReturnBuffer);

					return *(EPlayerMappableKeySlot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SlotToMatch, __InBuffer);
				}
			}
		}

		public bool bMatchBasicKeyTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMatchBasicKeyTypes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMatchBasicKeyTypes, __InBuffer);
				}
			}
		}

		public bool bMatchKeyAxisType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMatchKeyAxisType, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMatchKeyAxisType, __InBuffer);
				}
			}
		}

		public EHardwareDevicePrimaryType RequiredDeviceType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequiredDeviceType, __ReturnBuffer);

					return *(EHardwareDevicePrimaryType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequiredDeviceType, __InBuffer);
				}
			}
		}

		public int RequiredDeviceFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequiredDeviceFlags, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequiredDeviceFlags, __InBuffer);
				}
			}
		}

		private static uint __MappingName = 0;

		private static uint __KeyToMatch = 0;

		private static uint __SlotToMatch = 0;

		private static uint __bMatchBasicKeyTypes = 0;

		private static uint __bMatchKeyAxisType = 0;

		private static uint __RequiredDeviceType = 0;

		private static uint __RequiredDeviceFlags = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}