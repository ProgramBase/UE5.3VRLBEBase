using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray")]
	public partial class FRigUnit_HierarchyGetSiblingsItemArray : FRigUnit_HierarchyBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyGetSiblingsItemArray()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyGetSiblingsItemArray A, FRigUnit_HierarchyGetSiblingsItemArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyGetSiblingsItemArray A, FRigUnit_HierarchyGetSiblingsItemArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyGetSiblingsItemArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Item
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Item, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Item, __InBuffer);
				}
			}
		}

		public bool bIncludeItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeItem, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeItem, __InBuffer);
				}
			}
		}

		public TArray<FRigElementKey> Siblings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Siblings, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Siblings, __InBuffer);
				}
			}
		}

		public FCachedRigElement CachedItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedItem, __ReturnBuffer);

					return *(FCachedRigElement*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedItem, __InBuffer);
				}
			}
		}

		public FRigElementKeyCollection CachedSiblings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedSiblings, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedSiblings, __InBuffer);
				}
			}
		}

		private static uint __Item = 0;

		private static uint __bIncludeItem = 0;

		private static uint __Siblings = 0;

		private static uint __CachedItem = 0;

		private static uint __CachedSiblings = 0;

	}
}