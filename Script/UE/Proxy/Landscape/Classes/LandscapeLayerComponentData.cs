using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeLayerComponentData")]
	public partial class FLandscapeLayerComponentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeLayerComponentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeLayerComponentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeLayerComponentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeLayerComponentData A, FLandscapeLayerComponentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeLayerComponentData A, FLandscapeLayerComponentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeLayerComponentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName DebugName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DebugName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DebugName, __InBuffer);
				}
			}
		}

		public FHeightmapData HeightmapData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HeightmapData, __ReturnBuffer);

					return *(FHeightmapData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HeightmapData, __InBuffer);
				}
			}
		}

		public FWeightmapData WeightmapData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapData, __ReturnBuffer);

					return *(FWeightmapData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapData, __InBuffer);
				}
			}
		}

		private static uint __DebugName = 0;

		private static uint __HeightmapData = 0;

		private static uint __WeightmapData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}