using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeBaseNodeContainer")]
	public partial class UInterchangeBaseNodeContainer : UObject, IStaticClass
	{
		public TMap<FString, UInterchangeBaseNode> Nodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Nodes, __ReturnBuffer);

					return *(TMap<FString, UInterchangeBaseNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Nodes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeBaseNodeContainer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetNodeParentUid(FString NodeUniqueID, FString NewParentNodeUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewParentNodeUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeParentUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SaveToFile(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SaveToFile, __InBuffer);
			}
		}

		public virtual void ResetChildrenCache()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetChildrenCache);
			}
		}

		public virtual void ReplaceNode(FString NodeUniqueID, UInterchangeFactoryBaseNode NewNode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewNode?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceNode, __InBuffer);
			}
		}

		public virtual void LoadFromFile(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LoadFromFile, __InBuffer);
			}
		}

		public virtual bool IsNodeUidValid(FString NodeUniqueID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsNodeUidValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetRoots(ref TArray<FString> RootNodes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RootNodes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetRoots, __InBuffer, __OutBuffer);

				RootNodes = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetNodes(UClass ClassNode, ref TArray<FString> OutNodes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ClassNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutNodes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNodes, __InBuffer, __OutBuffer);

				OutNodes = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual TArray<FString> GetNodeChildrenUids(FString NodeUniqueID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNodeChildrenUids, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual int GetNodeChildrenCount(FString NodeUniqueID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNodeChildrenCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UInterchangeBaseNode GetNodeChildren(FString NodeUniqueID, int ChildIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ChildIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNodeChildren, __InBuffer, __ReturnBuffer);

				return *(UInterchangeBaseNode*)__ReturnBuffer;
			}
		}

		public virtual UInterchangeBaseNode GetNode(FString NodeUniqueID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNode, __InBuffer, __ReturnBuffer);

				return *(UInterchangeBaseNode*)__ReturnBuffer;
			}
		}

		public virtual UInterchangeFactoryBaseNode GetFactoryNode(FString NodeUniqueID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeUniqueID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetFactoryNode, __InBuffer, __ReturnBuffer);

				return *(UInterchangeFactoryBaseNode*)__ReturnBuffer;
			}
		}

		public virtual void ComputeChildrenCache()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ComputeChildrenCache);
			}
		}

		/// <param name="Node">
		/// - a pointer on the node you want to add
		/// </param>
		/// <returns>
		/// : return the node unique ID of the added item. If the node already exist it will return the existing ID. Return InvalidNodeUid if the node cannot be added.
		/// </returns>
		public virtual FString AddNode(UInterchangeBaseNode Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddNode, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __Nodes = 0;

		private static uint __SetNodeParentUid = 0;

		private static uint __SaveToFile = 0;

		private static uint __ResetChildrenCache = 0;

		private static uint __ReplaceNode = 0;

		private static uint __LoadFromFile = 0;

		private static uint __IsNodeUidValid = 0;

		private static uint __GetRoots = 0;

		private static uint __GetNodes = 0;

		private static uint __GetNodeChildrenUids = 0;

		private static uint __GetNodeChildrenCount = 0;

		private static uint __GetNodeChildren = 0;

		private static uint __GetNode = 0;

		private static uint __GetFactoryNode = 0;

		private static uint __ComputeChildrenCache = 0;

		private static uint __AddNode = 0;
	}
}