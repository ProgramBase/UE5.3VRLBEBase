using Script.CoreUObject;
using Script.Library;

namespace Script.PortalServices
{
	[PathName("/Script/PortalServices.PortalUserIsEntitledToItemResult")]
	public partial class FPortalUserIsEntitledToItemResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PortalServices.PortalUserIsEntitledToItemResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPortalUserIsEntitledToItemResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPortalUserIsEntitledToItemResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPortalUserIsEntitledToItemResult A, FPortalUserIsEntitledToItemResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPortalUserIsEntitledToItemResult A, FPortalUserIsEntitledToItemResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPortalUserIsEntitledToItemResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ItemId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ItemId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ItemId, __InBuffer);
				}
			}
		}

		public bool IsEntitled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IsEntitled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IsEntitled, __InBuffer);
				}
			}
		}

		public EEntitlementCacheLevelRetrieved RetrievedFromCacheLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RetrievedFromCacheLevel, __ReturnBuffer);

					return *(EEntitlementCacheLevelRetrieved*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RetrievedFromCacheLevel, __InBuffer);
				}
			}
		}

		private static uint __ItemId = 0;

		private static uint __IsEntitled = 0;

		private static uint __RetrievedFromCacheLevel = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}