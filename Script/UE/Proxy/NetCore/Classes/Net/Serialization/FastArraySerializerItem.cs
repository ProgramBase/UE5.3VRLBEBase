using Script.CoreUObject;
using Script.Library;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.FastArraySerializerItem")]
	public partial class FFastArraySerializerItem : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NetCore.FastArraySerializerItem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFastArraySerializerItem() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFastArraySerializerItem() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFastArraySerializerItem A, FFastArraySerializerItem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFastArraySerializerItem A, FFastArraySerializerItem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFastArraySerializerItem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ReplicationID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplicationID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplicationID, __InBuffer);
				}
			}
		}

		public int ReplicationKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplicationKey, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplicationKey, __InBuffer);
				}
			}
		}

		public int MostRecentArrayReplicationKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MostRecentArrayReplicationKey, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MostRecentArrayReplicationKey, __InBuffer);
				}
			}
		}

		private static uint __ReplicationID = 0;

		private static uint __ReplicationKey = 0;

		private static uint __MostRecentArrayReplicationKey = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}