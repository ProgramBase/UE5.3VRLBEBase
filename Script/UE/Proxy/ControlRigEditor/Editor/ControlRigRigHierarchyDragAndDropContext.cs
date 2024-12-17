using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext")]
	public partial class FControlRigRigHierarchyDragAndDropContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigRigHierarchyDragAndDropContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigRigHierarchyDragAndDropContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigRigHierarchyDragAndDropContext A, FControlRigRigHierarchyDragAndDropContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigRigHierarchyDragAndDropContext A, FControlRigRigHierarchyDragAndDropContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigRigHierarchyDragAndDropContext;

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

		public FRigElementKey TargetElementKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetElementKey, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetElementKey, __InBuffer);
				}
			}
		}

		private static uint __DraggedElementKeys = 0;

		private static uint __TargetElementKey = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}