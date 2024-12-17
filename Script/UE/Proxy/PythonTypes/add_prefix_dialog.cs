using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/add_prefix_dialog.add_prefix_dialog")]
	public partial class add_prefix_dialog : UObject, IStaticClass
	{
		public FString prefix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __prefix, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __prefix, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/add_prefix_dialog.add_prefix_dialog");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __prefix = 0;
	}
}