using Script.CoreUObject;
using Script.PhysicsCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInterface")]
	public partial class UMaterialInterface : UObject, IStaticClass, IBlendableInterface, IInterface_AssetUserData
	{
		public UMaterialInterfaceEditorOnlyData EditorOnlyData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorOnlyData, __ReturnBuffer);

					return *(UMaterialInterfaceEditorOnlyData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorOnlyData, __InBuffer);
				}
			}
		}

		public USubsurfaceProfile SubsurfaceProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubsurfaceProfile, __ReturnBuffer);

					return *(USubsurfaceProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubsurfaceProfile, __InBuffer);
				}
			}
		}

		public TArray<USpecularProfile> SpecularProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpecularProfiles, __ReturnBuffer);

					return *(TArray<USpecularProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpecularProfiles, __InBuffer);
				}
			}
		}

		public bool bIncludedInBaseGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludedInBaseGame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludedInBaseGame, __InBuffer);
				}
			}
		}

		public FLightmassMaterialInterfaceSettings LightmassSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __ReturnBuffer);

					return *(FLightmassMaterialInterfaceSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __InBuffer);
				}
			}
		}

		public bool bTextureStreamingDataSorted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTextureStreamingDataSorted, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTextureStreamingDataSorted, __InBuffer);
				}
			}
		}

		public int TextureStreamingDataVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureStreamingDataVersion, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureStreamingDataVersion, __InBuffer);
				}
			}
		}

		public TArray<FMaterialTextureInfo> TextureStreamingData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureStreamingData, __ReturnBuffer);

					return *(TArray<FMaterialTextureInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureStreamingData, __InBuffer);
				}
			}
		}

		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __ReturnBuffer);

					return *(TArray<UAssetUserData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __InBuffer);
				}
			}
		}

		public TArray<FMaterialTextureInfo> TextureStreamingDataMissingEntries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureStreamingDataMissingEntries, __ReturnBuffer);

					return *(TArray<FMaterialTextureInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureStreamingDataMissingEntries, __InBuffer);
				}
			}
		}

		public FSoftObjectPath PreviewMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMesh, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMesh, __InBuffer);
				}
			}
		}

		public UThumbnailInfo ThumbnailInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailInfo, __ReturnBuffer);

					return *(UThumbnailInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailInfo, __InBuffer);
				}
			}
		}

		public TMap<FString, bool> LayerParameterExpansion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LayerParameterExpansion, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LayerParameterExpansion, __InBuffer);
				}
			}
		}

		public TMap<FString, bool> ParameterOverviewExpansion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterOverviewExpansion, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterOverviewExpansion, __InBuffer);
				}
			}
		}

		public UAssetImportData AssetImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __ReturnBuffer);

					return *(UAssetImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __InBuffer);
				}
			}
		}

		public FGuid LightingGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightingGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightingGuid, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		/// <param name="OverrideForceMiplevelsToBeResident">
		/// - Whether to use (true) or ignore (false) the bForceMiplevelsToBeResidentValue parameter.
		/// </param>
		/// <param name="bForceMiplevelsToBeResidentValue">
		/// - true forces all mips to stream in. false lets other factors decide what to do with the mips.
		/// </param>
		/// <param name="ForceDuration">
		/// - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic. Negative value turns it off.
		/// </param>
		/// <param name="CinematicTextureGroups">
		/// - Bitfield indicating texture groups that should use extra high-resolution mips
		/// </param>
		/// <param name="bFastResponse">
		/// - USE WITH EXTREME CAUTION! Fast response textures incur sizable GT overhead and disturb streaming metric calculation. Avoid whenever possible.
		/// </param>
		public virtual void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups = 0, bool bFastResponse = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(bool*)(__InBuffer) = OverrideForceMiplevelsToBeResident;

				*(bool*)(__InBuffer + 1) = bForceMiplevelsToBeResidentValue;

				*(float*)(__InBuffer + 2) = ForceDuration;

				*(int*)(__InBuffer + 6) = CinematicTextureGroups;

				*(bool*)(__InBuffer + 10) = bFastResponse;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceMipLevelsToBeResident, __InBuffer);
			}
		}

		/// <returns>
		/// The physical material.
		/// </returns>
		public virtual UPhysicalMaterialMask GetPhysicalMaterialMask()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPhysicalMaterialMask, __ReturnBuffer);

				return *(UPhysicalMaterialMask*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The physical material.
		/// </returns>
		public virtual UPhysicalMaterial GetPhysicalMaterialFromMap(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPhysicalMaterialFromMap, __InBuffer, __ReturnBuffer);

				return *(UPhysicalMaterial*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The physical material.
		/// </returns>
		public virtual UPhysicalMaterial GetPhysicalMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPhysicalMaterial, __ReturnBuffer);

				return *(UPhysicalMaterial*)__ReturnBuffer;
			}
		}

		public virtual FMaterialParameterInfo GetParameterInfo(EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)Association;

				*(nint*)(__InBuffer + 1) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = LayerFunction?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParameterInfo, __InBuffer, __ReturnBuffer);

				return *(FMaterialParameterInfo*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInterface GetNaniteOverideMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNaniteOverideMaterial, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public virtual EBlendMode GetBlendMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetBlendMode, __ReturnBuffer);

				return *(EBlendMode*)__ReturnBuffer;
			}
		}

		public virtual UMaterial GetBaseMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBaseMaterial, __ReturnBuffer);

				return *(UMaterial*)__ReturnBuffer;
			}
		}

		private static uint __EditorOnlyData = 0;

		private static uint __SubsurfaceProfile = 0;

		private static uint __SpecularProfiles = 0;

		private static uint __bIncludedInBaseGame = 0;

		private static uint __LightmassSettings = 0;

		private static uint __bTextureStreamingDataSorted = 0;

		private static uint __TextureStreamingDataVersion = 0;

		private static uint __TextureStreamingData = 0;

		private static uint __AssetUserData = 0;

		private static uint __TextureStreamingDataMissingEntries = 0;

		private static uint __PreviewMesh = 0;

		private static uint __ThumbnailInfo = 0;

		private static uint __LayerParameterExpansion = 0;

		private static uint __ParameterOverviewExpansion = 0;

		private static uint __AssetImportData = 0;

		private static uint __LightingGuid = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetForceMipLevelsToBeResident = 0;

		private static uint __GetPhysicalMaterialMask = 0;

		private static uint __GetPhysicalMaterialFromMap = 0;

		private static uint __GetPhysicalMaterial = 0;

		private static uint __GetParameterInfo = 0;

		private static uint __GetNaniteOverideMaterial = 0;

		private static uint __GetBlendMode = 0;

		private static uint __GetBaseMaterial = 0;
	}
}