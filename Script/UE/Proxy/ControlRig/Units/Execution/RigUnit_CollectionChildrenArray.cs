using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionChildrenArray")]
	public partial class FRigUnit_CollectionChildrenArray : FRigUnit_CollectionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionChildrenArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionChildrenArray()
		{
		}

		public static bool operator ==(FRigUnit_CollectionChildrenArray A, FRigUnit_CollectionChildrenArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionChildrenArray A, FRigUnit_CollectionChildrenArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionChildrenArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Parent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parent, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parent, __InBuffer);
				}
			}
		}

		public bool bIncludeParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeParent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeParent, __InBuffer);
				}
			}
		}

		public bool bRecursive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecursive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecursive, __InBuffer);
				}
			}
		}

		public ERigElementType TypeToSearch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TypeToSearch, __ReturnBuffer);

					return *(ERigElementType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TypeToSearch, __InBuffer);
				}
			}
		}

		public TArray<FRigElementKey> Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Items, __InBuffer);
				}
			}
		}

		private static uint __Parent = 0;

		private static uint __bIncludeParent = 0;

		private static uint __bRecursive = 0;

		private static uint __TypeToSearch = 0;

		private static uint __Items = 0;

	}
}