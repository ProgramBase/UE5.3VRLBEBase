using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyAddControlInteger_Settings")]
	public partial class FRigUnit_HierarchyAddControlInteger_Settings : FRigUnit_HierarchyAddControl_Settings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyAddControlInteger_Settings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyAddControlInteger_Settings()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyAddControlInteger_Settings A, FRigUnit_HierarchyAddControlInteger_Settings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyAddControlInteger_Settings A, FRigUnit_HierarchyAddControlInteger_Settings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyAddControlInteger_Settings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERigControlAxis PrimaryAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAxis, __ReturnBuffer);

					return *(ERigControlAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAxis, __InBuffer);
				}
			}
		}

		public FRigUnit_HierarchyAddControlInteger_LimitSettings Limits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Limits, __ReturnBuffer);

					return *(FRigUnit_HierarchyAddControlInteger_LimitSettings*)__ReturnBuffer;
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

		private static uint __PrimaryAxis = 0;

		private static uint __Limits = 0;

		private static uint __Shape = 0;

		private static uint __Proxy = 0;

	}
}