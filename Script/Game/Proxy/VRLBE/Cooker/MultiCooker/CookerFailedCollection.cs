using Script.CoreUObject;
using Script.Library;
using Script.HotPatcherRuntime;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.CookerFailedCollection")]
	public partial class FCookerFailedCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherCore.CookerFailedCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCookerFailedCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCookerFailedCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCookerFailedCollection A, FCookerFailedCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCookerFailedCollection A, FCookerFailedCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCookerFailedCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString MissionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MissionName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MissionName, __InBuffer);
				}
			}
		}

		public int MissionID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MissionID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MissionID, __InBuffer);
				}
			}
		}

		public TMap<ETargetPlatform, FPackagePathSet> CookFailedAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CookFailedAssets, __ReturnBuffer);

					return *(TMap<ETargetPlatform, FPackagePathSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CookFailedAssets, __InBuffer);
				}
			}
		}

		private static uint __MissionName = 0;

		private static uint __MissionID = 0;

		private static uint __CookFailedAssets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}