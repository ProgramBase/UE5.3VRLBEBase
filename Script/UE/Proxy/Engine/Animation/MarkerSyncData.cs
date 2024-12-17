using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MarkerSyncData")]
	public partial class FMarkerSyncData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MarkerSyncData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMarkerSyncData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMarkerSyncData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMarkerSyncData A, FMarkerSyncData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMarkerSyncData A, FMarkerSyncData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMarkerSyncData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAnimSyncMarker> AuthoredSyncMarkers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AuthoredSyncMarkers, __ReturnBuffer);

					return *(TArray<FAnimSyncMarker>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AuthoredSyncMarkers, __InBuffer);
				}
			}
		}

		private static uint __AuthoredSyncMarkers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}