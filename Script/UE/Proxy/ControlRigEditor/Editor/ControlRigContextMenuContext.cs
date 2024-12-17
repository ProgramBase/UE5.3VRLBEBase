using Script.CoreUObject;
using Script.Library;
using Script.ControlRigDeveloper;
using Script.ControlRig;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigContextMenuContext")]
	public partial class UControlRigContextMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigContextMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsAltDown()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAltDown, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FControlRigRigHierarchyToGraphDragAndDropContext GetRigHierarchyToGraphDragAndDropContext()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRigHierarchyToGraphDragAndDropContext, __ReturnBuffer);

				return *(FControlRigRigHierarchyToGraphDragAndDropContext*)__ReturnBuffer;
			}
		}

		public virtual FControlRigRigHierarchyDragAndDropContext GetRigHierarchyDragAndDropContext()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRigHierarchyDragAndDropContext, __ReturnBuffer);

				return *(FControlRigRigHierarchyDragAndDropContext*)__ReturnBuffer;
			}
		}

		public virtual FControlRigGraphNodeContextMenuContext GetGraphNodeContextMenuContext()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGraphNodeContextMenuContext, __ReturnBuffer);

				return *(FControlRigGraphNodeContextMenuContext*)__ReturnBuffer;
			}
		}

		public virtual UControlRigBlueprint GetControlRigBlueprint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControlRigBlueprint, __ReturnBuffer);

				return *(UControlRigBlueprint*)__ReturnBuffer;
			}
		}

		public virtual UControlRig GetControlRig()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControlRig, __ReturnBuffer);

				return *(UControlRig*)__ReturnBuffer;
			}
		}

		private static uint __IsAltDown = 0;

		private static uint __GetRigHierarchyToGraphDragAndDropContext = 0;

		private static uint __GetRigHierarchyDragAndDropContext = 0;

		private static uint __GetGraphNodeContextMenuContext = 0;

		private static uint __GetControlRigBlueprint = 0;

		private static uint __GetControlRig = 0;
	}
}