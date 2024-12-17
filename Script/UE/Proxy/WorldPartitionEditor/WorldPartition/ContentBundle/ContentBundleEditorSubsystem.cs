using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.WorldPartitionEditor
{
	[PathName("/Script/WorldPartitionEditor.ContentBundleEditorSubsystem")]
	public partial class UContentBundleEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public UContentBundleEditingSubmodule ContentBundleEditingSubModule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleEditingSubModule, __ReturnBuffer);

					return *(UContentBundleEditingSubmodule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleEditingSubModule, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionEditor.ContentBundleEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ContentBundleEditingSubModule = 0;
	}
}