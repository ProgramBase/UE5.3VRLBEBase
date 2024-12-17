using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphNode")]
	public partial class URigVMEdGraphNode : UEdGraphNode, IStaticClass
	{
		public FString ModelNodePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModelNodePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModelNodePath, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<URigVMNode> CachedModelNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedModelNode, __ReturnBuffer);

					return *(TWeakObjectPtr<URigVMNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedModelNode, __InBuffer);
				}
			}
		}

		public TMap<FString, TWeakObjectPtr<URigVMPin>> PinPathToModelPin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PinPathToModelPin, __ReturnBuffer);

					return *(TMap<FString, TWeakObjectPtr<URigVMPin>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PinPathToModelPin, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMEdGraphNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ModelNodePath = 0;

		private static uint __CachedModelNode = 0;

		private static uint __PinPathToModelPin = 0;
	}
}