using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext")]
	public partial class FControlRigRigHierarchyToGraphDragAndDropContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigRigHierarchyToGraphDragAndDropContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigRigHierarchyToGraphDragAndDropContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigRigHierarchyToGraphDragAndDropContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigRigHierarchyToGraphDragAndDropContext A, FControlRigRigHierarchyToGraphDragAndDropContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigRigHierarchyToGraphDragAndDropContext A, FControlRigRigHierarchyToGraphDragAndDropContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigRigHierarchyToGraphDragAndDropContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> DraggedElementKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DraggedElementKeys, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DraggedElementKeys, __InBuffer);
				}
			}
		}

		private static uint __DraggedElementKeys = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}