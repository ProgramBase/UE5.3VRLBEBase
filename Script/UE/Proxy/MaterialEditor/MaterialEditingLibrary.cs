using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.MaterialEditingLibrary")]
	public partial class UMaterialEditingLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MaterialEditor.MaterialEditingLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void UpdateMaterialInstance(UMaterialInstanceConstant Instance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UpdateMaterialInstance, __InBuffer);
			}
		}

		public static void UpdateMaterialFunction(UMaterialFunctionInterface MaterialFunction, UMaterial PreviewMaterial = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UpdateMaterialFunction, __InBuffer);
			}
		}

		/// <param name="Material">
		/// Material to change usage for
		/// </param>
		/// <param name="Usage">
		/// New usage type to enable for this material
		/// </param>
		/// <param name="bNeedsRecompile">
		/// Returned to indicate if material needs recompiling after this change
		/// </param>
		public static bool SetMaterialUsage(UMaterial Material, EMaterialUsage Usage, ref bool bNeedsRecompile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Usage;

				*(bool*)(__InBuffer + 9) = bNeedsRecompile;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialUsage, __InBuffer, __OutBuffer, __ReturnBuffer);

				bNeedsRecompile = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetMaterialInstanceVectorParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, FLinearColor Value, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceVectorParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetMaterialInstanceTextureParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, UTexture Value, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetMaterialInstanceStaticSwitchParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, bool Value, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Value;

				*(byte*)(__InBuffer + 17) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceStaticSwitchParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetMaterialInstanceSparseVolumeTextureParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, USparseVolumeTexture Value, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceSparseVolumeTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetMaterialInstanceScalarParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, float Value, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Value;

				*(byte*)(__InBuffer + 20) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceScalarParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetMaterialInstanceRuntimeVirtualTextureParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, URuntimeVirtualTexture Value, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceRuntimeVirtualTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void SetMaterialInstanceParent(UMaterialInstanceConstant Instance, UMaterialInterface NewParent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewParent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialInstanceParent, __InBuffer);
			}
		}

		public static void RecompileMaterial(UMaterial Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RecompileMaterial, __InBuffer);
			}
		}

		public static void LayoutMaterialFunctionExpressions(UMaterialFunction MaterialFunction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LayoutMaterialFunctionExpressions, __InBuffer);
			}
		}

		public static void LayoutMaterialExpressions(UMaterial Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LayoutMaterialExpressions, __InBuffer);
			}
		}

		/// <param name="Material">
		/// Material to check usage for
		/// </param>
		/// <param name="Usage">
		/// Usage type to check for this material
		/// </param>
		public static bool HasMaterialUsage(UMaterial Material, EMaterialUsage Usage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Usage;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasMaterialUsage, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Material">
		/// The material or material instance you want to look up a parameter from
		/// </param>
		/// <param name="ParameterName">
		/// The parameter name
		/// </param>
		/// <param name="ParameterSource">
		/// The soft object path of the asset the parameter originates in
		/// </param>
		/// <returns>
		/// Whether or not the parameter was found in this material
		/// </returns>
		public static bool GetVectorParameterSource(UMaterialInterface Material, FName ParameterName, ref FSoftObjectPath ParameterSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterSource?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetVectorParameterSource, __InBuffer, __OutBuffer, __ReturnBuffer);

				ParameterSource = *(FSoftObjectPath*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetVectorParameterNames(UMaterialInterface Material, ref TArray<FName> ParameterNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetVectorParameterNames, __InBuffer, __OutBuffer);

				ParameterNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static TArray<UTexture> GetUsedTextures(UMaterial Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUsedTextures, __InBuffer, __ReturnBuffer);

				return *(TArray<UTexture>*)__ReturnBuffer;
			}
		}

		/// <param name="Material">
		/// The material or material instance you want to look up a parameter from
		/// </param>
		/// <param name="ParameterName">
		/// The parameter name
		/// </param>
		/// <param name="ParameterSource">
		/// The soft object path of the asset the parameter originates in
		/// </param>
		/// <returns>
		/// Whether or not the parameter was found in this material
		/// </returns>
		public static bool GetTextureParameterSource(UMaterialInterface Material, FName ParameterName, ref FSoftObjectPath ParameterSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterSource?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetTextureParameterSource, __InBuffer, __OutBuffer, __ReturnBuffer);

				ParameterSource = *(FSoftObjectPath*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetTextureParameterNames(UMaterialInterface Material, ref TArray<FName> ParameterNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetTextureParameterNames, __InBuffer, __OutBuffer);

				ParameterNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static FMaterialStatistics GetStatistics(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStatistics, __InBuffer, __ReturnBuffer);

				return *(FMaterialStatistics*)__ReturnBuffer;
			}
		}

		/// <param name="Material">
		/// The material or material instance you want to look up a parameter from
		/// </param>
		/// <param name="ParameterName">
		/// The parameter name
		/// </param>
		/// <param name="ParameterSource">
		/// The soft object path of the asset the parameter originates in
		/// </param>
		/// <returns>
		/// Whether or not the parameter was found in this material
		/// </returns>
		public static bool GetStaticSwitchParameterSource(UMaterialInterface Material, FName ParameterName, ref FSoftObjectPath ParameterSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterSource?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetStaticSwitchParameterSource, __InBuffer, __OutBuffer, __ReturnBuffer);

				ParameterSource = *(FSoftObjectPath*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetStaticSwitchParameterNames(UMaterialInterface Material, ref TArray<FName> ParameterNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetStaticSwitchParameterNames, __InBuffer, __OutBuffer);

				ParameterNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		/// <param name="Material">
		/// The material or material instance you want to look up a parameter from
		/// </param>
		/// <param name="ParameterName">
		/// The parameter name
		/// </param>
		/// <param name="ParameterSource">
		/// The soft object path of the asset the parameter originates in 
		/// </param>
		/// <returns>
		/// Whether or not the parameter was found in this material
		/// </returns>
		public static bool GetScalarParameterSource(UMaterialInterface Material, FName ParameterName, ref FSoftObjectPath ParameterSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ParameterSource?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetScalarParameterSource, __InBuffer, __OutBuffer, __ReturnBuffer);

				ParameterSource = *(FSoftObjectPath*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetScalarParameterNames(UMaterialInterface Material, ref TArray<FName> ParameterNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetScalarParameterNames, __InBuffer, __OutBuffer);

				ParameterNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static int GetNumMaterialExpressionsInFunction(UMaterialFunction MaterialFunction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumMaterialExpressionsInFunction, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumMaterialExpressions(UMaterial Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumMaterialExpressions, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static UMaterialInterface GetNaniteOverrideMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNaniteOverrideMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public static TSet<UObject> GetMaterialSelectedNodes(UMaterial Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialSelectedNodes, __InBuffer, __ReturnBuffer);

				return *(TSet<UObject>*)__ReturnBuffer;
			}
		}

		public static FString GetMaterialPropertyInputNodeOutputName(UMaterial Material, EMaterialProperty Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Property;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialPropertyInputNodeOutputName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UMaterialExpression GetMaterialPropertyInputNode(UMaterial Material, EMaterialProperty Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Property;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialPropertyInputNode, __InBuffer, __ReturnBuffer);

				return *(UMaterialExpression*)__ReturnBuffer;
			}
		}

		public static FLinearColor GetMaterialInstanceVectorParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialInstanceVectorParameterValue, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static UTexture GetMaterialInstanceTextureParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialInstanceTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(UTexture*)__ReturnBuffer;
			}
		}

		public static bool GetMaterialInstanceStaticSwitchParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialInstanceStaticSwitchParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static USparseVolumeTexture GetMaterialInstanceSparseVolumeTextureParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialInstanceSparseVolumeTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(USparseVolumeTexture*)__ReturnBuffer;
			}
		}

		public static float GetMaterialInstanceScalarParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialInstanceScalarParameterValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static URuntimeVirtualTexture GetMaterialInstanceRuntimeVirtualTextureParameterValue(UMaterialInstanceConstant Instance, FName ParameterName, EMaterialParameterAssociation Association = EMaterialParameterAssociation.GlobalParameter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Association;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialInstanceRuntimeVirtualTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(URuntimeVirtualTexture*)__ReturnBuffer;
			}
		}

		public static void GetMaterialExpressionNodePosition(UMaterialExpression MaterialExpression, ref int NodePosX, ref int NodePosY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MaterialExpression?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NodePosX;

				*(int*)(__InBuffer + 12) = NodePosY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialExpressionNodePosition, __InBuffer, __OutBuffer);

				NodePosX = *(int*)(__OutBuffer);

				NodePosY = *(int*)(__OutBuffer + 4);

			}
		}

		public static TArray<int> GetMaterialExpressionInputTypes(UMaterialExpression MaterialExpression)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialExpression?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialExpressionInputTypes, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetMaterialExpressionInputNames(UMaterialExpression MaterialExpression)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialExpression?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialExpressionInputNames, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static FLinearColor GetMaterialDefaultVectorParameterValue(UMaterial Material, FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialDefaultVectorParameterValue, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static UTexture GetMaterialDefaultTextureParameterValue(UMaterial Material, FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialDefaultTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(UTexture*)__ReturnBuffer;
			}
		}

		public static bool GetMaterialDefaultStaticSwitchParameterValue(UMaterial Material, FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialDefaultStaticSwitchParameterValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static float GetMaterialDefaultScalarParameterValue(UMaterial Material, FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialDefaultScalarParameterValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static TArray<UMaterialExpression> GetInputsForMaterialExpression(UMaterial Material, UMaterialExpression MaterialExpression)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialExpression?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInputsForMaterialExpression, __InBuffer, __ReturnBuffer);

				return *(TArray<UMaterialExpression>*)__ReturnBuffer;
			}
		}

		public static bool GetInputNodeOutputNameForMaterialExpression(UMaterialExpression MaterialExpression, UMaterialExpression InputNode, ref FString OutputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MaterialExpression?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetInputNodeOutputNameForMaterialExpression, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutputName = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetChildInstances(UMaterialInterface Parent, ref TArray<FAssetData> ChildInstances)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ChildInstances?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetChildInstances, __InBuffer, __OutBuffer);

				ChildInstances = *(TArray<FAssetData>*)(__OutBuffer);

			}
		}

		/// <param name="Material">
		/// Material asset to add an expression to
		/// </param>
		/// <param name="MaterialFunction">
		/// Specified if adding an expression to a MaterialFunction, used as Outer for new expression object
		/// </param>
		/// <param name="SourceExpression">
		/// Expression to be duplicated
		/// </param>
		public static UMaterialExpression DuplicateMaterialExpression(UMaterial Material, UMaterialFunction MaterialFunction, UMaterialExpression Expression)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Expression?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DuplicateMaterialExpression, __InBuffer, __ReturnBuffer);

				return *(UMaterialExpression*)__ReturnBuffer;
			}
		}

		public static void DeleteMaterialExpressionInFunction(UMaterialFunction MaterialFunction, UMaterialExpression Expression)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expression?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteMaterialExpressionInFunction, __InBuffer);
			}
		}

		public static void DeleteMaterialExpression(UMaterial Material, UMaterialExpression Expression)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expression?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteMaterialExpression, __InBuffer);
			}
		}

		public static void DeleteAllMaterialExpressionsInFunction(UMaterialFunction MaterialFunction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteAllMaterialExpressionsInFunction, __InBuffer);
			}
		}

		public static void DeleteAllMaterialExpressions(UMaterial Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteAllMaterialExpressions, __InBuffer);
			}
		}

		/// <param name="MaterialFunction">
		/// Material function asset to add an expression to
		/// </param>
		/// <param name="ExpressionClass">
		/// Class of expression to add
		/// </param>
		/// <param name="NodePosX">
		/// X position of new expression node
		/// </param>
		/// <param name="NodePosY">
		/// Y position of new expression node
		/// </param>
		public static UMaterialExpression CreateMaterialExpressionInFunction(UMaterialFunction MaterialFunction, TSubclassOf<UMaterialExpression> ExpressionClass, int NodePosX = 0, int NodePosY = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MaterialFunction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpressionClass?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = NodePosX;

				*(int*)(__InBuffer + 20) = NodePosY;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateMaterialExpressionInFunction, __InBuffer, __ReturnBuffer);

				return *(UMaterialExpression*)__ReturnBuffer;
			}
		}

		/// <param name="Material">
		/// Material asset to add an expression to
		/// </param>
		/// <param name="ExpressionClass">
		/// Class of expression to add
		/// </param>
		/// <param name="NodePosX">
		/// X position of new expression node
		/// </param>
		/// <param name="NodePosY">
		/// Y position of new expression node
		/// </param>
		public static UMaterialExpression CreateMaterialExpression(UMaterial Material, TSubclassOf<UMaterialExpression> ExpressionClass, int NodePosX = 0, int NodePosY = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpressionClass?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = NodePosX;

				*(int*)(__InBuffer + 20) = NodePosY;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateMaterialExpression, __InBuffer, __ReturnBuffer);

				return *(UMaterialExpression*)__ReturnBuffer;
			}
		}

		/// <param name="FromExpression">
		/// Expression to make connection from
		/// </param>
		/// <param name="FromOutputName">
		/// Name of output of FromExpression to make connection from
		/// </param>
		/// <param name="Property">
		/// Property input on material to make connection to
		/// </param>
		public static bool ConnectMaterialProperty(UMaterialExpression FromExpression, FString FromOutputName, EMaterialProperty Property)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = FromExpression?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FromOutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Property;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConnectMaterialProperty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="FromExpression">
		/// Expression to make connection from
		/// </param>
		/// <param name="FromOutputName">
		/// Name of output of FromExpression to make connection from. Leave empty to use first output.
		/// </param>
		/// <param name="ToExpression">
		/// Expression to make connection to
		/// </param>
		/// <param name="ToInputName">
		/// Name of input of ToExpression to make connection to. Leave empty to use first input.
		/// </param>
		public static bool ConnectMaterialExpressions(UMaterialExpression FromExpression, FString FromOutputName, UMaterialExpression ToExpression, FString ToInputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = FromExpression?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FromOutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ToExpression?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ToInputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConnectMaterialExpressions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void ClearAllMaterialInstanceParameters(UMaterialInstanceConstant Instance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearAllMaterialInstanceParameters, __InBuffer);
			}
		}

		private static uint __UpdateMaterialInstance = 0;

		private static uint __UpdateMaterialFunction = 0;

		private static uint __SetMaterialUsage = 0;

		private static uint __SetMaterialInstanceVectorParameterValue = 0;

		private static uint __SetMaterialInstanceTextureParameterValue = 0;

		private static uint __SetMaterialInstanceStaticSwitchParameterValue = 0;

		private static uint __SetMaterialInstanceSparseVolumeTextureParameterValue = 0;

		private static uint __SetMaterialInstanceScalarParameterValue = 0;

		private static uint __SetMaterialInstanceRuntimeVirtualTextureParameterValue = 0;

		private static uint __SetMaterialInstanceParent = 0;

		private static uint __RecompileMaterial = 0;

		private static uint __LayoutMaterialFunctionExpressions = 0;

		private static uint __LayoutMaterialExpressions = 0;

		private static uint __HasMaterialUsage = 0;

		private static uint __GetVectorParameterSource = 0;

		private static uint __GetVectorParameterNames = 0;

		private static uint __GetUsedTextures = 0;

		private static uint __GetTextureParameterSource = 0;

		private static uint __GetTextureParameterNames = 0;

		private static uint __GetStatistics = 0;

		private static uint __GetStaticSwitchParameterSource = 0;

		private static uint __GetStaticSwitchParameterNames = 0;

		private static uint __GetScalarParameterSource = 0;

		private static uint __GetScalarParameterNames = 0;

		private static uint __GetNumMaterialExpressionsInFunction = 0;

		private static uint __GetNumMaterialExpressions = 0;

		private static uint __GetNaniteOverrideMaterial = 0;

		private static uint __GetMaterialSelectedNodes = 0;

		private static uint __GetMaterialPropertyInputNodeOutputName = 0;

		private static uint __GetMaterialPropertyInputNode = 0;

		private static uint __GetMaterialInstanceVectorParameterValue = 0;

		private static uint __GetMaterialInstanceTextureParameterValue = 0;

		private static uint __GetMaterialInstanceStaticSwitchParameterValue = 0;

		private static uint __GetMaterialInstanceSparseVolumeTextureParameterValue = 0;

		private static uint __GetMaterialInstanceScalarParameterValue = 0;

		private static uint __GetMaterialInstanceRuntimeVirtualTextureParameterValue = 0;

		private static uint __GetMaterialExpressionNodePosition = 0;

		private static uint __GetMaterialExpressionInputTypes = 0;

		private static uint __GetMaterialExpressionInputNames = 0;

		private static uint __GetMaterialDefaultVectorParameterValue = 0;

		private static uint __GetMaterialDefaultTextureParameterValue = 0;

		private static uint __GetMaterialDefaultStaticSwitchParameterValue = 0;

		private static uint __GetMaterialDefaultScalarParameterValue = 0;

		private static uint __GetInputsForMaterialExpression = 0;

		private static uint __GetInputNodeOutputNameForMaterialExpression = 0;

		private static uint __GetChildInstances = 0;

		private static uint __DuplicateMaterialExpression = 0;

		private static uint __DeleteMaterialExpressionInFunction = 0;

		private static uint __DeleteMaterialExpression = 0;

		private static uint __DeleteAllMaterialExpressionsInFunction = 0;

		private static uint __DeleteAllMaterialExpressions = 0;

		private static uint __CreateMaterialExpressionInFunction = 0;

		private static uint __CreateMaterialExpression = 0;

		private static uint __ConnectMaterialProperty = 0;

		private static uint __ConnectMaterialExpressions = 0;

		private static uint __ClearAllMaterialInstanceParameters = 0;
	}
}