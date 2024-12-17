using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.BitfieldNetSerializerConfig")]
	public partial class FBitfieldNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.BitfieldNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBitfieldNetSerializerConfig()
		{
		}

		public static bool operator ==(FBitfieldNetSerializerConfig A, FBitfieldNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBitfieldNetSerializerConfig A, FBitfieldNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBitfieldNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte BitMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BitMask, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BitMask, __InBuffer);
				}
			}
		}

		private static uint __BitMask = 0;

	}
}