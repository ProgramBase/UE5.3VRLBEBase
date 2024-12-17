using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.Int8RangeNetSerializerConfig")]
	public partial class FInt8RangeNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.Int8RangeNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInt8RangeNetSerializerConfig()
		{
		}

		public static bool operator ==(FInt8RangeNetSerializerConfig A, FInt8RangeNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInt8RangeNetSerializerConfig A, FInt8RangeNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInt8RangeNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public sbyte LowerBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __InBuffer);
				}
			}
		}

		public sbyte UpperBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpperBound, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

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