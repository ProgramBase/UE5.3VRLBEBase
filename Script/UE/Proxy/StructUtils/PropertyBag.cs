using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.PropertyBag")]
	public partial class UPropertyBag : UScriptStruct, IStaticClass
	{
		public TArray<FPropertyBagPropertyDesc> PropertyDescs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyDescs, __ReturnBuffer);

					return *(TArray<FPropertyBagPropertyDesc>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyDescs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtils.PropertyBag");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PropertyDescs = 0;
	}
}