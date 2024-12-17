using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings")]
	public partial class FRigUnit_HierarchyAddControlVector_Settings : FRigUnit_HierarchyAddControl_Settings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyAddControlVector_Settings()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyAddControlVector_Settings A, FRigUnit_HierarchyAddControlVector_Settings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyAddControlVector_Settings A, FRigUnit_HierarchyAddControlVector_Settings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyAddControlVector_Settings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERigVMTransformSpace InitialSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialSpace, __ReturnBuffer);

					return *(ERigVMTransformSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialSpace, __InBuffer);
				}
			}
		}

		public bool bIsPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPosition, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPosition, __InBuffer);
				}
			}
		}

		public FRigUnit_HierarchyAddControlVector_LimitSettings Limits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Limits, __ReturnBuffer);

					return *(FRigUnit_HierarchyAddControlVector_LimitSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Limits, __InBuffer);
				}
			}
		}

		public FRigUnit_HierarchyAddControl_ShapeSettings Shape
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Shape, __ReturnBuffer);

					return *(FRigUnit_HierarchyAddControl_ShapeSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Shape, __InBuffer);
				}
			}
		}

		public FRigUnit_HierarchyAddControl_ProxySettings Proxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Proxy, __ReturnBuffer);

					return *(FRigUnit_HierarchyAddControl_ProxySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Proxy, __InBuffer);
				}
			}
		}

		public TArray<ERigControlTransformChannel> FilteredChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilteredChannels, __ReturnBuffer);

					return *(TArray<ERigControlTransformChannel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilteredChannels, __InBuffer);
				}
			}
		}

		private static uint __InitialSpace = 0;

		private static uint __bIsPosition = 0;

		private static uint __Limits = 0;

		private static uint __Shape = 0;

		private static uint __Proxy = 0;

		private static uint __FilteredChannels = 0;

	}
}