using Script.CoreUObject;
using Script.Library;
using Script.NetCore;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.IrisFastArraySerializer")]
	public partial class FIrisFastArraySerializer : FFastArraySerializer, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.IrisFastArraySerializer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIrisFastArraySerializer()
		{
		}

		public static bool operator ==(FIrisFastArraySerializer A, FIrisFastArraySerializer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIrisFastArraySerializer A, FIrisFastArraySerializer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIrisFastArraySerializer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint ChangeMaskStorage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChangeMaskStorage, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChangeMaskStorage, __InBuffer);
				}
			}
		}

		private static uint __ChangeMaskStorage = 0;

	}
}