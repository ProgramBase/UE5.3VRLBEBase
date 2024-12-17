using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigHierarchyContainer")]
	public partial class FRigHierarchyContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigHierarchyContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigHierarchyContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigHierarchyContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigHierarchyContainer A, FRigHierarchyContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigHierarchyContainer A, FRigHierarchyContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigHierarchyContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigBoneHierarchy BoneHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneHierarchy, __ReturnBuffer);

					return *(FRigBoneHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneHierarchy, __InBuffer);
				}
			}
		}

		public FRigSpaceHierarchy SpaceHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpaceHierarchy, __ReturnBuffer);

					return *(FRigSpaceHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpaceHierarchy, __InBuffer);
				}
			}
		}

		public FRigControlHierarchy ControlHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlHierarchy, __ReturnBuffer);

					return *(FRigControlHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlHierarchy, __InBuffer);
				}
			}
		}

		public FRigCurveContainer CurveContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveContainer, __ReturnBuffer);

					return *(FRigCurveContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveContainer, __InBuffer);
				}
			}
		}

		private static uint __BoneHierarchy = 0;

		private static uint __SpaceHierarchy = 0;

		private static uint __ControlHierarchy = 0;

		private static uint __CurveContainer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}