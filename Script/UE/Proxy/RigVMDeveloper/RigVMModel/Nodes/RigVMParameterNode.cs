using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMParameterNode")]
	public partial class URigVMParameterNode : URigVMNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMParameterNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsInput()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInput, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName GetParameterName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParameterName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FRigVMGraphParameterDescription GetParameterDescription()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParameterDescription, __ReturnBuffer);

				return *(FRigVMGraphParameterDescription*)__ReturnBuffer;
			}
		}

		public virtual FString GetDefaultValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultValue, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
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

		private static uint __IsInput = 0;

		private static uint __GetParameterName = 0;

		private static uint __GetParameterDescription = 0;

		private static uint __GetDefaultValue = 0;

		private static uint __GetCPPTypeObject = 0;

		private static uint __GetCPPType = 0;
	}
}