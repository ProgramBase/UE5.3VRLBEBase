using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_TwistBones_WorkData")]
	public partial class FRigUnit_TwistBones_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_TwistBones_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_TwistBones_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_TwistBones_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_TwistBones_WorkData A, FRigUnit_TwistBones_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_TwistBones_WorkData A, FRigUnit_TwistBones_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_TwistBones_WorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedItems, __ReturnBuffer);

					return *(TArray<FCachedRigElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedItems, __InBuffer);
				}
			}
		}

		public TArray<float> ItemRatios
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ItemRatios, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ItemRatios, __InBuffer);
				}
			}
		}

		public TArray<FTransform> ItemTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ItemTransforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ItemTransforms, __InBuffer);
				}
			}
		}

		private static uint __CachedItems = 0;

		private static uint __ItemRatios = 0;

		private static uint __ItemTransforms = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}