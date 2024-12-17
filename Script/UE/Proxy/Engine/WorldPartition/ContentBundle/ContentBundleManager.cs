using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ContentBundleManager")]
	public partial class UContentBundleManager : UObject, IStaticClass
	{
		public UContentBundleDuplicateForPIEHelper PIEDuplicateHelper
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PIEDuplicateHelper, __ReturnBuffer);

					return *(UContentBundleDuplicateForPIEHelper*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PIEDuplicateHelper, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ContentBundleManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PIEDuplicateHelper = 0;
	}
}