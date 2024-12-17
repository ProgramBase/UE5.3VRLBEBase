using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.IntNetSerializerConfig")]
	public partial class FIntNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.IntNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIntNetSerializerConfig()
		{
		}

		public static bool operator ==(FIntNetSerializerConfig A, FIntNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIntNetSerializerConfig A, FIntNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIntNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		private static uint __BitCount = 0;

	}
}