using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.EnumUint16NetSerializerConfig")]
	public partial class FEnumUint16NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.EnumUint16NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEnumUint16NetSerializerConfig()
		{
		}

		public static bool operator ==(FEnumUint16NetSerializerConfig A, FEnumUint16NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEnumUint16NetSerializerConfig A, FEnumUint16NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEnumUint16NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ushort LowerBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __InBuffer);
				}
			}
		}

		public ushort UpperBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpperBound, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpperBound, __InBuffer);
				}
			}
		}

		public byte BitCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BitCount, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BitCount, __InBuffer);
				}
			}
		}

		private static uint __LowerBound = 0;

		private static uint __UpperBound = 0;

		private static uint __BitCount = 0;

	}
}