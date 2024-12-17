using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.WorldBrowser
{
	[PathName("/Script/WorldBrowser.TileLODEntryDetails")]
	public partial class FTileLODEntryDetails : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WorldBrowser.TileLODEntryDetails");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTileLODEntryDetails() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTileLODEntryDetails() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTileLODEntryDetails A, FTileLODEntryDetails B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTileLODEntryDetails A, FTileLODEntryDetails B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTileLODEntryDetails;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int LODIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __InBuffer);
				}
			}
		}

		public int RelativeDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RelativeDistance, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RelativeDistance, __InBuffer);
				}
			}
		}

		public FLevelSimplificationDetails SimplificationDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SimplificationDetails, __ReturnBuffer);

					return *(FLevelSimplificationDetails*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SimplificationDetails, __InBuffer);
				}
			}
		}

		private static uint __LODIndex = 0;

		private static uint __RelativeDistance = 0;

		private static uint __SimplificationDetails = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}