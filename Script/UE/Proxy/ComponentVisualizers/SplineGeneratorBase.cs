using Script.CoreUObject;
using Script.Library;

namespace Script.ComponentVisualizers
{
	[PathName("/Script/ComponentVisualizers.SplineGeneratorBase")]
	public partial class USplineGeneratorBase : UObject, IStaticClass
	{
		public EShapeAddMode ShapeAddMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeAddMode, __ReturnBuffer);

					return *(EShapeAddMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeAddMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ComponentVisualizers.SplineGeneratorBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ShapeAddMode = 0;
	}
}