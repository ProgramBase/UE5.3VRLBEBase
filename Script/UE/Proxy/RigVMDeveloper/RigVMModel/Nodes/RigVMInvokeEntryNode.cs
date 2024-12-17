using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMInvokeEntryNode")]
	public partial class URigVMInvokeEntryNode : URigVMNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMInvokeEntryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FName GetEntryName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEntryName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __GetEntryName = 0;
	}
}