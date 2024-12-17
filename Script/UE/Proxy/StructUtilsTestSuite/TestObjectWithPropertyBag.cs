using Script.CoreUObject;
using Script.StructUtils;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.TestObjectWithPropertyBag")]
	public partial class UTestObjectWithPropertyBag : UObject, IStaticClass
	{
		public FInstancedPropertyBag Bag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Bag, __ReturnBuffer);

					return *(FInstancedPropertyBag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Bag, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsTestSuite.TestObjectWithPropertyBag");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Bag = 0;
	}
}