using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEdGraphTemplateNodeSpawner")]
	public partial class URigVMEdGraphTemplateNodeSpawner : URigVMEdGraphNodeSpawner, IStaticClass
	{
		public FName TemplateNotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateNotation, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateNotation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEdGraphTemplateNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TemplateNotation = 0;
	}
}