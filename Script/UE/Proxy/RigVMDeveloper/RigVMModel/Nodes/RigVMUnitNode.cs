using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMUnitNode")]
	public partial class URigVMUnitNode : URigVMTemplateNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMUnitNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FString GetStructDefaultValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStructDefaultValue, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FName GetMethodName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMethodName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __GetStructDefaultValue = 0;

		private static uint __GetMethodName = 0;
	}
}