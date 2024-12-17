using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.VersionData")]
	public partial class FVersionData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MegascansPlugin.VersionData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVersionData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVersionData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVersionData A, FVersionData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVersionData A, FVersionData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVersionData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAssetInfo> assets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __assets, __ReturnBuffer);

					return *(TArray<FAssetInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __assets, __InBuffer);
				}
			}
		}

		private static uint __assets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}