using Script.CoreUObject;
using Script.Library;

namespace Script.UObjectPlugin
{
	[PathName("/Script/UObjectPlugin.MyPluginObject")]
	public partial class UMyPluginObject : UObject, IStaticClass
	{
		public FMyPluginStruct MyStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MyStruct, __ReturnBuffer);

					return *(FMyPluginStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MyStruct, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UObjectPlugin.MyPluginObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MyStruct = 0;
	}
}