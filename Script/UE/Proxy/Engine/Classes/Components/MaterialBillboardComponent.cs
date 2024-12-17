using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialBillboardComponent")]
	public partial class UMaterialBillboardComponent : UPrimitiveComponent, IStaticClass
	{
		public TArray<FMaterialSpriteElement> Elements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Elements, __ReturnBuffer);

					return *(TArray<FMaterialSpriteElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Elements, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialBillboardComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetElements(TArray<FMaterialSpriteElement> NewElements)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewElements?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetElements, __InBuffer);
			}
		}

		public virtual void AddElement(UMaterialInterface Material, UCurveFloat DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, UCurveFloat DistanceToSizeCurve)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DistanceToOpacityCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSizeIsInScreenSpace;

				*(float*)(__InBuffer + 17) = BaseSizeX;

				*(float*)(__InBuffer + 21) = BaseSizeY;

				*(nint*)(__InBuffer + 25) = DistanceToSizeCurve?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddElement, __InBuffer);
			}
		}

		private static uint __Elements = 0;

		private static uint __SetElements = 0;

		private static uint __AddElement = 0;
	}
}