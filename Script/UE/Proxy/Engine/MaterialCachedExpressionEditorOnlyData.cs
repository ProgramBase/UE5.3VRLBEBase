using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialCachedExpressionEditorOnlyData")]
	public partial class FMaterialCachedExpressionEditorOnlyData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialCachedExpressionEditorOnlyData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialCachedExpressionEditorOnlyData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialCachedExpressionEditorOnlyData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialCachedExpressionEditorOnlyData A, FMaterialCachedExpressionEditorOnlyData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialCachedExpressionEditorOnlyData A, FMaterialCachedExpressionEditorOnlyData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialCachedExpressionEditorOnlyData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMaterialCachedParameterEntry EditorOnlyEntries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorOnlyEntries, __ReturnBuffer);

					return *(FMaterialCachedParameterEntry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorOnlyEntries, __InBuffer);
				}
			}
		}

		public FMaterialCachedParameterEditorEntry EditorEntries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorEntries, __ReturnBuffer);

					return *(FMaterialCachedParameterEditorEntry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorEntries, __InBuffer);
				}
			}
		}

		public TArray<FStaticComponentMaskValue> StaticComponentMaskValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticComponentMaskValues, __ReturnBuffer);

					return *(TArray<FStaticComponentMaskValue>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticComponentMaskValues, __InBuffer);
				}
			}
		}

		public TArray<FVector2D> ScalarMinMaxValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScalarMinMaxValues, __ReturnBuffer);

					return *(TArray<FVector2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScalarMinMaxValues, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UCurveLinearColor>> ScalarCurveValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScalarCurveValues, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UCurveLinearColor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScalarCurveValues, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UCurveLinearColorAtlas>> ScalarCurveAtlasValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScalarCurveAtlasValues, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UCurveLinearColorAtlas>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScalarCurveAtlasValues, __InBuffer);
				}
			}
		}

		public TArray<FParameterChannelNames> VectorChannelNameValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VectorChannelNameValues, __ReturnBuffer);

					return *(TArray<FParameterChannelNames>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VectorChannelNameValues, __InBuffer);
				}
			}
		}

		public TArray<bool> VectorUsedAsChannelMaskValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VectorUsedAsChannelMaskValues, __ReturnBuffer);

					return *(TArray<bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VectorUsedAsChannelMaskValues, __InBuffer);
				}
			}
		}

		public TArray<FParameterChannelNames> TextureChannelNameValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextureChannelNameValues, __ReturnBuffer);

					return *(TArray<FParameterChannelNames>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextureChannelNameValues, __InBuffer);
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

		public TArray<FString> AssetPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetPaths, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetPaths, __InBuffer);
				}
			}
		}

		public TArray<FName> LandscapeLayerNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LandscapeLayerNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LandscapeLayerNames, __InBuffer);
				}
			}
		}

		private static uint __EditorOnlyEntries = 0;

		private static uint __EditorEntries = 0;

		private static uint __StaticComponentMaskValues = 0;

		private static uint __ScalarMinMaxValues = 0;

		private static uint __ScalarCurveValues = 0;

		private static uint __ScalarCurveAtlasValues = 0;

		private static uint __VectorChannelNameValues = 0;

		private static uint __VectorUsedAsChannelMaskValues = 0;

		private static uint __TextureChannelNameValues = 0;

		private static uint __MaterialLayers = 0;

		private static uint __AssetPaths = 0;

		private static uint __LandscapeLayerNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}