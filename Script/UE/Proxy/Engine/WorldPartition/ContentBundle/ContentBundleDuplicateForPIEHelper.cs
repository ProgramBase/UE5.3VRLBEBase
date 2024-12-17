using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ContentBundleDuplicateForPIEHelper")]
	public partial class UContentBundleDuplicateForPIEHelper : UObject, IStaticClass
	{
		public TMap<FGuid, URuntimeHashExternalStreamingObjectBase> StreamingObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingObjects, __ReturnBuffer);

					return *(TMap<FGuid, URuntimeHashExternalStreamingObjectBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingObjects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ContentBundleDuplicateForPIEHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StreamingObjects = 0;
	}
}