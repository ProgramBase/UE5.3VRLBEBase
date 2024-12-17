using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_GetTransformItemArray")]
	public partial class FRigUnit_GetTransformItemArray : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_GetTransformItemArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_GetTransformItemArray()
		{
		}

		public static bool operator ==(FRigUnit_GetTransformItemArray A, FRigUnit_GetTransformItemArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_GetTransformItemArray A, FRigUnit_GetTransformItemArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_GetTransformItemArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public ERigVMTransformSpace Space
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Space, __ReturnBuffer);

					return *(ERigVMTransformSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Space, __InBuffer);
				}
			}
		}

		public bool bInitial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bInitial, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bInitial, __InBuffer);
				}
			}
		}

		public TArray<FTransform> Transforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __InBuffer);
				}
			}
		}

		public TArray<FCachedRigElement> CachedIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedIndex, __ReturnBuffer);

					return *(TArray<FCachedRigElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedIndex, __InBuffer);
				}
			}
		}

		private static uint __Items = 0;

		private static uint __Space = 0;

		private static uint __bInitial = 0;

		private static uint __Transforms = 0;

		private static uint __CachedIndex = 0;

	}
}