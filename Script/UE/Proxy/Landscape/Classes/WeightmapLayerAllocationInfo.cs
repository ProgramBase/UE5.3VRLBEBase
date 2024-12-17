using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.WeightmapLayerAllocationInfo")]
	public partial class FWeightmapLayerAllocationInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.WeightmapLayerAllocationInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWeightmapLayerAllocationInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWeightmapLayerAllocationInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWeightmapLayerAllocationInfo A, FWeightmapLayerAllocationInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWeightmapLayerAllocationInfo A, FWeightmapLayerAllocationInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWeightmapLayerAllocationInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ULandscapeLayerInfoObject LayerInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerInfo, __ReturnBuffer);

					return *(ULandscapeLayerInfoObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerInfo, __InBuffer);
				}
			}
		}

		public byte WeightmapTextureIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapTextureIndex, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapTextureIndex, __InBuffer);
				}
			}
		}

		public byte WeightmapTextureChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapTextureChannel, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapTextureChannel, __InBuffer);
				}
			}
		}

		private static uint __LayerInfo = 0;

		private static uint __WeightmapTextureIndex = 0;

		private static uint __WeightmapTextureChannel = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}