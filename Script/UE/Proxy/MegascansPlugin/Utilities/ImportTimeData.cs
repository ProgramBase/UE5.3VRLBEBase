using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.ImportTimeData")]
	public partial class FImportTimeData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MegascansPlugin.ImportTimeData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FImportTimeData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FImportTimeData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FImportTimeData A, FImportTimeData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FImportTimeData A, FImportTimeData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FImportTimeData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAssetImportTime> assets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __assets, __ReturnBuffer);

					return *(TArray<FAssetImportTime>*)__ReturnBuffer;
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