using Script.CoreUObject;
using Script.RigVM;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMArrayNode")]
	public partial class UDEPRECATED_RigVMArrayNode : URigVMTemplateNode, IStaticClass
	{
		public ERigVMOpCode OpCode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OpCode, __ReturnBuffer);

					return *(ERigVMOpCode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OpCode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMArrayNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual ERigVMOpCode GetOpCode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOpCode, __ReturnBuffer);

				return *(ERigVMOpCode*)__ReturnBuffer;
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

		private static uint __OpCode = 0;

		private static uint __GetOpCode = 0;

		private static uint __GetCPPTypeObject = 0;

		private static uint __GetCPPType = 0;
	}
}