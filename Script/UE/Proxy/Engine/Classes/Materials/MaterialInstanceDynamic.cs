using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInstanceDynamic")]
	public partial class UMaterialInstanceDynamic : UMaterialInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialInstanceDynamic");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo, FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorParameterValueByInfo, __InBuffer);
			}
		}

		public virtual void SetVectorParameterValue(FName ParameterName, FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorParameterValue, __InBuffer);
			}
		}

		public virtual void SetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo, UTexture Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextureParameterValueByInfo, __InBuffer);
			}
		}

		public virtual void SetTextureParameterValue(FName ParameterName, UTexture Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextureParameterValue, __InBuffer);
			}
		}

		public virtual void SetSparseVolumeTextureParameterValue(FName ParameterName, USparseVolumeTexture Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSparseVolumeTextureParameterValue, __InBuffer);
			}
		}

		public virtual void SetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScalarParameterValueByInfo, __InBuffer);
			}
		}

		public virtual void SetScalarParameterValue(FName ParameterName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScalarParameterValue, __InBuffer);
			}
		}

		public virtual bool SetScalarParameterByIndex(int ParameterIndex, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = ParameterIndex;

				*(float*)(__InBuffer + 4) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetScalarParameterByIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetRuntimeVirtualTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo, URuntimeVirtualTexture Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRuntimeVirtualTextureParameterValueByInfo, __InBuffer);
			}
		}

		public virtual void SetRuntimeVirtualTextureParameterValue(FName ParameterName, URuntimeVirtualTexture Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRuntimeVirtualTextureParameterValue, __InBuffer);
			}
		}

		public virtual void SetDoubleVectorParameterValue(FName ParameterName, FVector4 Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDoubleVectorParameterValue, __InBuffer);
			}
		}

		/// <param name="SourceA">
		/// value that is used for Alpha=0, silently ignores the case if 0
		/// </param>
		/// <param name="SourceB">
		/// value that is used for Alpha=1, silently ignores the case if 0
		/// </param>
		/// <param name="Alpha">
		/// usually in the range 0..1, values outside the range extrapolate
		/// </param>
		public virtual void K2_InterpolateMaterialInstanceParams(UMaterialInstance SourceA, UMaterialInstance SourceB, float Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = SourceA?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceB?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_InterpolateMaterialInstanceParams, __InBuffer);
			}
		}

		public virtual FLinearColor K2_GetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetVectorParameterValueByInfo, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor K2_GetVectorParameterValue(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetVectorParameterValue, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual UTexture K2_GetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetTextureParameterValueByInfo, __InBuffer, __ReturnBuffer);

				return *(UTexture*)__ReturnBuffer;
			}
		}

		public virtual UTexture K2_GetTextureParameterValue(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetTextureParameterValue, __InBuffer, __ReturnBuffer);

				return *(UTexture*)__ReturnBuffer;
			}
		}

		public virtual float K2_GetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_GetScalarParameterValueByInfo, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float K2_GetScalarParameterValue(FName ParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_GetScalarParameterValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="bQuickParametersOnly">
		/// Copy scalar, vector and texture parameters only. Much faster but may not include required data
		/// </param>
		public virtual void K2_CopyMaterialInstanceParameters(UMaterialInterface Source, bool bQuickParametersOnly = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Source?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bQuickParametersOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_CopyMaterialInstanceParameters, __InBuffer);
			}
		}

		public virtual bool InitializeScalarParameterAndGetIndex(FName ParameterName, float Value, ref int OutParameterIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				*(int*)(__InBuffer + 12) = OutParameterIndex;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __InitializeScalarParameterAndGetIndex, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutParameterIndex = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void CopyParameterOverrides(UMaterialInstance MaterialInstance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialInstance?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CopyParameterOverrides, __InBuffer);
			}
		}

		/// <param name="Source">
		/// ignores the call if 0
		/// </param>
		public virtual void CopyInterpParameters(UMaterialInstance Source)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Source?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CopyInterpParameters, __InBuffer);
			}
		}

		private static uint __SetVectorParameterValueByInfo = 0;

		private static uint __SetVectorParameterValue = 0;

		private static uint __SetTextureParameterValueByInfo = 0;

		private static uint __SetTextureParameterValue = 0;

		private static uint __SetSparseVolumeTextureParameterValue = 0;

		private static uint __SetScalarParameterValueByInfo = 0;

		private static uint __SetScalarParameterValue = 0;

		private static uint __SetScalarParameterByIndex = 0;

		private static uint __SetRuntimeVirtualTextureParameterValueByInfo = 0;

		private static uint __SetRuntimeVirtualTextureParameterValue = 0;

		private static uint __SetDoubleVectorParameterValue = 0;

		private static uint __K2_InterpolateMaterialInstanceParams = 0;

		private static uint __K2_GetVectorParameterValueByInfo = 0;

		private static uint __K2_GetVectorParameterValue = 0;

		private static uint __K2_GetTextureParameterValueByInfo = 0;

		private static uint __K2_GetTextureParameterValue = 0;

		private static uint __K2_GetScalarParameterValueByInfo = 0;

		private static uint __K2_GetScalarParameterValue = 0;

		private static uint __K2_CopyMaterialInstanceParameters = 0;

		private static uint __InitializeScalarParameterAndGetIndex = 0;

		private static uint __CopyParameterOverrides = 0;

		private static uint __CopyInterpParameters = 0;
	}
}