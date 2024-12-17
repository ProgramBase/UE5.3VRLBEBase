using Script.CoreUObject;
using Script.Library;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.FastArraySerializer")]
	public partial class FFastArraySerializer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NetCore.FastArraySerializer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFastArraySerializer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFastArraySerializer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFastArraySerializer A, FFastArraySerializer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFastArraySerializer A, FFastArraySerializer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFastArraySerializer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ArrayReplicationKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArrayReplicationKey, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArrayReplicationKey, __InBuffer);
				}
			}
		}

		public EFastArraySerializerDeltaFlags DeltaFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeltaFlags, __ReturnBuffer);

					return *(EFastArraySerializerDeltaFlags*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeltaFlags, __InBuffer);
				}
			}
		}

		private static uint __ArrayReplicationKey = 0;

		private static uint __DeltaFlags = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}