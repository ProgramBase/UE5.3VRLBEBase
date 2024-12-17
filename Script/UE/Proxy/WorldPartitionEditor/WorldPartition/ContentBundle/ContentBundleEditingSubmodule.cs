using Script.CoreUObject;
using Script.Library;

namespace Script.WorldPartitionEditor
{
	[PathName("/Script/WorldPartitionEditor.ContentBundleEditingSubmodule")]
	public partial class UContentBundleEditingSubmodule : UContentBundleEditorSubsystemModule, IStaticClass
	{
		public TArray<FGuid> EditingContentBundlesStack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditingContentBundlesStack, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditingContentBundlesStack, __InBuffer);
				}
			}
		}

		public FGuid EditingContentBundleGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditingContentBundleGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditingContentBundleGuid, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionEditor.ContentBundleEditingSubmodule");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditingContentBundlesStack = 0;

		private static uint __EditingContentBundleGuid = 0;
	}
}