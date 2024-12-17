using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeMaterialTextureStreamingInfo")]
	public partial class FLandscapeMaterialTextureStreamingInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeMaterialTextureStreamingInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeMaterialTextureStreamingInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeMaterialTextureStreamingInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeMaterialTextureStreamingInfo A, FLandscapeMaterialTextureStreamingInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeMaterialTextureStreamingInfo A, FLandscapeMaterialTextureStreamingInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeMaterialTextureStreamingInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName TextureName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextureName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextureName, __InBuffer);
				}
			}
		}

		public float TexelFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TexelFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TexelFactor, __InBuffer);
				}
			}
		}

		private static uint __TextureName = 0;

		private static uint __TexelFactor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}