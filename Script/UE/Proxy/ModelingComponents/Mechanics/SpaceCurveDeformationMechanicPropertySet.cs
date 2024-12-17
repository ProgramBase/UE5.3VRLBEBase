using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.SpaceCurveDeformationMechanicPropertySet")]
	public partial class USpaceCurveDeformationMechanicPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public ESpaceCurveControlPointTransformMode TransformMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformMode, __ReturnBuffer);

					return *(ESpaceCurveControlPointTransformMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformMode, __InBuffer);
				}
			}
		}

		public ESpaceCurveControlPointOriginMode TransformOrigin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformOrigin, __ReturnBuffer);

					return *(ESpaceCurveControlPointOriginMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformOrigin, __InBuffer);
				}
			}
		}

		public float Softness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Softness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Softness, __InBuffer);
				}
			}
		}

		public ESpaceCurveControlPointFalloffType SoftFalloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoftFalloff, __ReturnBuffer);

					return *(ESpaceCurveControlPointFalloffType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoftFalloff, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.SpaceCurveDeformationMechanicPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TransformMode = 0;

		private static uint __TransformOrigin = 0;

		private static uint __Softness = 0;

		private static uint __SoftFalloff = 0;
	}
}