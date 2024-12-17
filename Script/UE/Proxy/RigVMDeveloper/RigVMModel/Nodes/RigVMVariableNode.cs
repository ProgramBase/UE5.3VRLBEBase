using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMVariableNode")]
	public partial class URigVMVariableNode : URigVMNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMVariableNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsLocalVariable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocalVariable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInputArgument()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInputArgument, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsGetter()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsGetter, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsExternalVariable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsExternalVariable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName GetVariableName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVariableName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FRigVMGraphVariableDescription GetVariableDescription()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVariableDescription, __ReturnBuffer);

				return *(FRigVMGraphVariableDescription*)__ReturnBuffer;
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

		private static uint __IsLocalVariable = 0;

		private static uint __IsInputArgument = 0;

		private static uint __IsGetter = 0;

		private static uint __IsExternalVariable = 0;

		private static uint __GetVariableName = 0;

		private static uint __GetVariableDescription = 0;

		private static uint __GetDefaultValue = 0;

		private static uint __GetCPPTypeObject = 0;

		private static uint __GetCPPType = 0;
	}
}