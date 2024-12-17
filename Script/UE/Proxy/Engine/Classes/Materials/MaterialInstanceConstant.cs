using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInstanceConstant")]
	public partial class UMaterialInstanceConstant : UMaterialInstance, IStaticClass
	{
		public FGuid ParameterStateId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterStateId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterStateId, __InBuffer);
				}
			}
		}

		public UPhysicalMaterialMask PhysMaterialMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysMaterialMask, __ReturnBuffer);

					return *(UPhysicalMaterialMask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysMaterialMask, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialInstanceConstant");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetNaniteOverrideMaterial(bool bInEnableOverride, UMaterialInterface InOverrideMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bInEnableOverride;

				*(nint*)(__InBuffer + 1) = InOverrideMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNaniteOverrideMaterial, __InBuffer);
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

		private static uint __ParameterStateId = 0;

		private static uint __PhysMaterialMask = 0;

		private static uint __SetNaniteOverrideMaterial = 0;

		private static uint __K2_GetVectorParameterValue = 0;

		private static uint __K2_GetTextureParameterValue = 0;

		private static uint __K2_GetScalarParameterValue = 0;
	}
}