using Script.CoreUObject;
using Script.Library;
using Script.RigVM;
using Script.RigVMDeveloper;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEditorMenuContext")]
	public partial class URigVMEditorMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEditorMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsAltDown()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAltDown, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVMHost GetRigVMHost()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRigVMHost, __ReturnBuffer);

				return *(URigVMHost*)__ReturnBuffer;
			}
		}

		public virtual URigVMBlueprint GetRigVMBlueprint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRigVMBlueprint, __ReturnBuffer);

				return *(URigVMBlueprint*)__ReturnBuffer;
			}
		}

		public virtual FRigVMEditorGraphMenuContext GetGraphMenuContext()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGraphMenuContext, __ReturnBuffer);

				return *(FRigVMEditorGraphMenuContext*)__ReturnBuffer;
			}
		}

		private static uint __IsAltDown = 0;

		private static uint __GetRigVMHost = 0;

		private static uint __GetRigVMBlueprint = 0;

		private static uint __GetGraphMenuContext = 0;
	}
}