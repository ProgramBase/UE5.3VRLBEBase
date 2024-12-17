using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEnumNode")]
	public partial class URigVMEnumNode : URigVMNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMEnumNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UEnum GetEnum()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEnum, __ReturnBuffer);

				return *(UEnum*)__ReturnBuffer;
			}
		}

		public virtual UObject GetCPPTypeObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCPPTypeObject, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual FString GetCPPType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCPPType, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __GetEnum = 0;

		private static uint __GetCPPTypeObject = 0;

		private static uint __GetCPPType = 0;
	}
}