using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MarkerSyncAnimPosition")]
	public partial class FMarkerSyncAnimPosition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MarkerSyncAnimPosition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMarkerSyncAnimPosition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMarkerSyncAnimPosition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMarkerSyncAnimPosition A, FMarkerSyncAnimPosition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMarkerSyncAnimPosition A, FMarkerSyncAnimPosition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMarkerSyncAnimPosition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PreviousMarkerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousMarkerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousMarkerName, __InBuffer);
				}
			}
		}

		public FName NextMarkerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NextMarkerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NextMarkerName, __InBuffer);
				}
			}
		}

		public float PositionBetweenMarkers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PositionBetweenMarkers, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PositionBetweenMarkers, __InBuffer);
				}
			}
		}

		private static uint __PreviousMarkerName = 0;

		private static uint __NextMarkerName = 0;

		private static uint __PositionBetweenMarkers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}