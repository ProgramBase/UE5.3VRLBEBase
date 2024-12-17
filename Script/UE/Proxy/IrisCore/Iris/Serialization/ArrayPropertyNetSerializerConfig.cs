using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ArrayPropertyNetSerializerConfig")]
	public partial class FArrayPropertyNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.ArrayPropertyNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FArrayPropertyNetSerializerConfig()
		{
		}

		public static bool operator ==(FArrayPropertyNetSerializerConfig A, FArrayPropertyNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FArrayPropertyNetSerializerConfig A, FArrayPropertyNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FArrayPropertyNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ushort MaxElementCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxElementCount, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxElementCount, __InBuffer);
				}
			}
		}

		public ushort ElementCountBitCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ElementCountBitCount, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ElementCountBitCount, __InBuffer);
				}
			}
		}

		public TFieldPath<FArrayProperty> Property
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Property, __ReturnBuffer);

					return *(TFieldPath<FArrayProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Property, __InBuffer);
				}
			}
		}

		private static uint __MaxElementCount = 0;

		private static uint __ElementCountBitCount = 0;

		private static uint __Property = 0;

	}
}