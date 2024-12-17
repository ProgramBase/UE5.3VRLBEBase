using Script.CoreUObject;
using Script.Library;

namespace Script.ComponentVisualizers
{
	[PathName("/Script/ComponentVisualizers.SquareSplineGenerator")]
	public partial class USquareSplineGenerator : USplineGeneratorBase, IStaticClass
	{
		public float Length
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Length, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Length, __InBuffer);
				}
			}
		}

		public bool bBranchRight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBranchRight, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBranchRight, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ComponentVisualizers.SquareSplineGenerator");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Length = 0;

		private static uint __bBranchRight = 0;
	}
}