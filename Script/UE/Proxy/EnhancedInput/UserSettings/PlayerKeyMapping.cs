using Script.CoreUObject;
using Script.Library;
using Script.InputCore;
using Script.Engine;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.PlayerKeyMapping")]
	public partial class FPlayerKeyMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.PlayerKeyMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlayerKeyMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlayerKeyMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlayerKeyMapping A, FPlayerKeyMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlayerKeyMapping A, FPlayerKeyMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlayerKeyMapping;

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

		public FText DisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DisplayName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DisplayName, __InBuffer);
				}
			}
		}

		public FText DisplayCategory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DisplayCategory, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DisplayCategory, __InBuffer);
				}
			}
		}

		public EPlayerMappableKeySlot Slot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Slot, __ReturnBuffer);

					return *(EPlayerMappableKeySlot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Slot, __InBuffer);
				}
			}
		}

		public bool bIsDirty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsDirty, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsDirty, __InBuffer);
				}
			}
		}

		public FKey DefaultKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultKey, __ReturnBuffer);

					return *(FKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultKey, __InBuffer);
				}
			}
		}

		public FKey CurrentKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentKey, __ReturnBuffer);

					return *(FKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentKey, __InBuffer);
				}
			}
		}

		public FHardwareDeviceIdentifier HardwareDeviceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HardwareDeviceId, __ReturnBuffer);

					return *(FHardwareDeviceIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HardwareDeviceId, __InBuffer);
				}
			}
		}

		public UInputAction AssociatedInputAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssociatedInputAction, __ReturnBuffer);

					return *(UInputAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssociatedInputAction, __InBuffer);
				}
			}
		}

		private static uint __MappingName = 0;

		private static uint __DisplayName = 0;

		private static uint __DisplayCategory = 0;

		private static uint __Slot = 0;

		private static uint __bIsDirty = 0;

		private static uint __DefaultKey = 0;

		private static uint __CurrentKey = 0;

		private static uint __HardwareDeviceId = 0;

		private static uint __AssociatedInputAction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}