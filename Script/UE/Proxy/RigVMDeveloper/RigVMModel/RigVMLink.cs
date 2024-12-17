using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMLink")]
	public partial class URigVMLink : UObject, IStaticClass
	{
		public FString SourcePinPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourcePinPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourcePinPath, __InBuffer);
				}
			}
		}

		public FString TargetPinPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetPinPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetPinPath, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMLink");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual URigVMPin GetTargetPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTargetPin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode GetTargetNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTargetNode, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetSourcePin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSourcePin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode GetSourceNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSourceNode, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual FString GetPinPathRepresentation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPinPathRepresentation, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetOppositePin(URigVMPin InPin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPin?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOppositePin, __InBuffer, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual int GetLinkIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLinkIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetGraphDepth()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGraphDepth, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		private static uint __SourcePinPath = 0;

		private static uint __TargetPinPath = 0;

		private static uint __GetTargetPin = 0;

		private static uint __GetTargetNode = 0;

		private static uint __GetSourcePin = 0;

		private static uint __GetSourceNode = 0;

		private static uint __GetPinPathRepresentation = 0;

		private static uint __GetOppositePin = 0;

		private static uint __GetLinkIndex = 0;

		private static uint __GetGraphDepth = 0;

		private static uint __GetGraph = 0;
	}
}