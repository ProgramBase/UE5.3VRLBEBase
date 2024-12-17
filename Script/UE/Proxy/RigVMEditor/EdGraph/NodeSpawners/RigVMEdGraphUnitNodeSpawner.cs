using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEdGraphUnitNodeSpawner")]
	public partial class URigVMEdGraphUnitNodeSpawner : URigVMEdGraphNodeSpawner, IStaticClass
	{
		public UScriptStruct StructTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StructTemplate, __ReturnBuffer);

					return *(UScriptStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StructTemplate, __InBuffer);
				}
			}
		}

		public FName MethodName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MethodName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MethodName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEdGraphUnitNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StructTemplate = 0;

		private static uint __MethodName = 0;
	}
}