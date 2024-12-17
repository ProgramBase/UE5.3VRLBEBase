using Script.CoreUObject;
using Script.Library;

namespace Script.StructViewer
{
	[PathName("/Script/StructViewer.StructViewerProjectSettings")]
	public partial class UStructViewerProjectSettings : UObject, IStaticClass
	{
		public TArray<FDirectoryPath> InternalOnlyPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyPaths, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyPaths, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UScriptStruct>> InternalOnlyStructs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyStructs, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UScriptStruct>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyStructs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructViewer.StructViewerProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InternalOnlyPaths = 0;

		private static uint __InternalOnlyStructs = 0;
	}
}