using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.VectorCurveCopyObject")]
	public partial class UVectorCurveCopyObject : UAnimCurveBaseCopyObject, IStaticClass
	{
		public FVectorCurve Curve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Curve, __ReturnBuffer);

					return *(FVectorCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Curve, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.VectorCurveCopyObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Curve = 0;
	}
}