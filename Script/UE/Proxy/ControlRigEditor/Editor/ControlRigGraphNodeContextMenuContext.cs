using Script.CoreUObject;
using Script.Library;
using Script.RigVMDeveloper;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext")]
	public partial class FControlRigGraphNodeContextMenuContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigGraphNodeContextMenuContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigGraphNodeContextMenuContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigGraphNodeContextMenuContext A, FControlRigGraphNodeContextMenuContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigGraphNodeContextMenuContext A, FControlRigGraphNodeContextMenuContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigGraphNodeContextMenuContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public URigVMGraph Graph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Graph, __ReturnBuffer);

					return *(URigVMGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Graph, __InBuffer);
				}
			}
		}

		public URigVMNode Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(URigVMNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Node, __InBuffer);
				}
			}
		}

		public URigVMPin Pin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pin, __ReturnBuffer);

					return *(URigVMPin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pin, __InBuffer);
				}
			}
		}

		private static uint __Graph = 0;

		private static uint __Node = 0;

		private static uint __Pin = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}