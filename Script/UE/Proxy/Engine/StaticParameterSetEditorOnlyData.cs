using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticParameterSetEditorOnlyData")]
	public partial class FStaticParameterSetEditorOnlyData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StaticParameterSetEditorOnlyData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticParameterSetEditorOnlyData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStaticParameterSetEditorOnlyData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStaticParameterSetEditorOnlyData A, FStaticParameterSetEditorOnlyData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticParameterSetEditorOnlyData A, FStaticParameterSetEditorOnlyData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticParameterSetEditorOnlyData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticComponentMaskParameters, __ReturnBuffer);

					return *(TArray<FStaticComponentMaskParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticComponentMaskParameters, __InBuffer);
				}
			}
		}

		public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TerrainLayerWeightParameters, __ReturnBuffer);

					return *(TArray<FStaticTerrainLayerWeightParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TerrainLayerWeightParameters, __InBuffer);
				}
			}
		}

		public FMaterialLayersFunctionsEditorOnlyData MaterialLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialLayers, __ReturnBuffer);

					return *(FMaterialLayersFunctionsEditorOnlyData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialLayers, __InBuffer);
				}
			}
		}

		private static uint __StaticComponentMaskParameters = 0;

		private static uint __TerrainLayerWeightParameters = 0;

		private static uint __MaterialLayers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}