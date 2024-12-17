using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterNetworkSerializationPackedBitsNetSerializerConfig")]
	public partial class FCharacterNetworkSerializationPackedBitsNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CharacterNetworkSerializationPackedBitsNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterNetworkSerializationPackedBitsNetSerializerConfig()
		{
		}

		public static bool operator ==(FCharacterNetworkSerializationPackedBitsNetSerializerConfig A, FCharacterNetworkSerializationPackedBitsNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterNetworkSerializationPackedBitsNetSerializerConfig A, FCharacterNetworkSerializationPackedBitsNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterNetworkSerializationPackedBitsNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint MaxAllowedDataBits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedDataBits, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedDataBits, __InBuffer);
				}
			}
		}

		public uint MaxAllowedObjectReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedObjectReferences, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedObjectReferences, __InBuffer);
				}
			}
		}

		private static uint __MaxAllowedDataBits = 0;

		private static uint __MaxAllowedObjectReferences = 0;

	}
}