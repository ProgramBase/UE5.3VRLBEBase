using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshComponent")]
	public partial class UMeshComponent : UPrimitiveComponent, IStaticClass
	{
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __InBuffer);
				}
			}
		}

		public UMaterialInterface OverlayMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __InBuffer);
				}
			}
		}

		public float OverlayMaterialMaxDrawDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterialMaxDrawDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterialMaxDrawDistance, __InBuffer);
				}
			}
		}

		public bool bEnableMaterialParameterCaching
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMaterialParameterCaching, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMaterialParameterCaching, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVectorParameterValueOnMaterials(FName ParameterName, FVector ParameterValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParameterValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorParameterValueOnMaterials, __InBuffer);
			}
		}

		public virtual void SetScalarParameterValueOnMaterials(FName ParameterName, float ParameterValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ParameterValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScalarParameterValueOnMaterials, __InBuffer);
			}
		}

		public virtual void SetOverlayMaterialMaxDrawDistance(float InMaxDrawDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMaxDrawDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverlayMaterialMaxDrawDistance, __InBuffer);
			}
		}

		public virtual void SetOverlayMaterial(UMaterialInterface NewOverlayMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewOverlayMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverlayMaterial, __InBuffer);
			}
		}

		/// <param name="Seconds">
		/// Number of seconds to force all mip-levels to be resident
		/// </param>
		/// <param name="bPrioritizeCharacterTextures">
		/// Whether character textures should be prioritized for a while by the streaming system
		/// </param>
		/// <param name="CinematicTextureGroups">
		/// Bitfield indicating which texture groups that use extra high-resolution mips
		/// </param>
		public virtual void PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = Seconds;

				*(bool*)(__InBuffer + 4) = bPrioritizeCharacterTextures;

				*(int*)(__InBuffer + 5) = CinematicTextureGroups;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PrestreamTextures, __InBuffer);
			}
		}

		public virtual bool IsMaterialSlotNameValid(FName MaterialSlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsMaterialSlotNameValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetOverlayMaterialMaxDrawDistance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOverlayMaterialMaxDrawDistance, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInterface GetOverlayMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOverlayMaterial, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetMaterialSlotNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterialSlotNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual TArray<UMaterialInterface> GetMaterials()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterials, __ReturnBuffer);

				return *(TArray<UMaterialInterface>*)__ReturnBuffer;
			}
		}

		public virtual int GetMaterialIndex(FName MaterialSlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMaterialIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __OverrideMaterials = 0;

		private static uint __OverlayMaterial = 0;

		private static uint __OverlayMaterialMaxDrawDistance = 0;

		private static uint __bEnableMaterialParameterCaching = 0;

		private static uint __SetVectorParameterValueOnMaterials = 0;

		private static uint __SetScalarParameterValueOnMaterials = 0;

		private static uint __SetOverlayMaterialMaxDrawDistance = 0;

		private static uint __SetOverlayMaterial = 0;

		private static uint __PrestreamTextures = 0;

		private static uint __IsMaterialSlotNameValid = 0;

		private static uint __GetOverlayMaterialMaxDrawDistance = 0;

		private static uint __GetOverlayMaterial = 0;

		private static uint __GetMaterialSlotNames = 0;

		private static uint __GetMaterials = 0;

		private static uint __GetMaterialIndex = 0;
	}
}