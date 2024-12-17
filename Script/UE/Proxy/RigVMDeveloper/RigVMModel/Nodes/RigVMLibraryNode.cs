using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMLibraryNode")]
	public partial class URigVMLibraryNode : URigVMTemplateNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMLibraryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual URigVMFunctionLibrary GetLibrary()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLibrary, __ReturnBuffer);

				return *(URigVMFunctionLibrary*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetContainedGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetContainedGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		private static uint __GetLibrary = 0;

		private static uint __GetContainedGraph = 0;
	}
}