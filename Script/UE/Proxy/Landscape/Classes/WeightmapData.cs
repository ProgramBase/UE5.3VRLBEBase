using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.WeightmapData")]
	public partial class FWeightmapData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.WeightmapData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWeightmapData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWeightmapData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWeightmapData A, FWeightmapData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWeightmapData A, FWeightmapData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWeightmapData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UTexture2D> Textures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Textures, __ReturnBuffer);

					return *(TArray<UTexture2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Textures, __InBuffer);
				}
			}
		}

		public TArray<FWeightmapLayerAllocationInfo> LayerAllocations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerAllocations, __ReturnBuffer);

					return *(TArray<FWeightmapLayerAllocationInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerAllocations, __InBuffer);
				}
			}
		}

		public TArray<ULandscapeWeightmapUsage> TextureUsages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextureUsages, __ReturnBuffer);

					return *(TArray<ULandscapeWeightmapUsage>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextureUsages, __InBuffer);
				}
			}
		}

		private static uint __Textures = 0;

		private static uint __LayerAllocations = 0;

		private static uint __TextureUsages = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}