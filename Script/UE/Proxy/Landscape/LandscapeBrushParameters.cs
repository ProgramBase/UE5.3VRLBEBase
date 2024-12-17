using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeBrushParameters")]
	public partial class FLandscapeBrushParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeBrushParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeBrushParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeBrushParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeBrushParameters A, FLandscapeBrushParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeBrushParameters A, FLandscapeBrushParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeBrushParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ELandscapeToolTargetType LayerType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerType, __ReturnBuffer);

					return *(ELandscapeToolTargetType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerType, __InBuffer);
				}
			}
		}

		public UTextureRenderTarget2D CombinedResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CombinedResult, __ReturnBuffer);

					return *(UTextureRenderTarget2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CombinedResult, __InBuffer);
				}
			}
		}

		public FName WeightmapLayerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapLayerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightmapLayerName, __InBuffer);
				}
			}
		}

		private static uint __LayerType = 0;

		private static uint __CombinedResult = 0;

		private static uint __WeightmapLayerName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}