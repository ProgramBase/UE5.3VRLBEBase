using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_BoneHarmonics_WorkData")]
	public partial class FRigUnit_BoneHarmonics_WorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_BoneHarmonics_WorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_BoneHarmonics_WorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_BoneHarmonics_WorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_BoneHarmonics_WorkData A, FRigUnit_BoneHarmonics_WorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_BoneHarmonics_WorkData A, FRigUnit_BoneHarmonics_WorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_BoneHarmonics_WorkData;

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

		public FVector WaveTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WaveTime, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WaveTime, __InBuffer);
				}
			}
		}

		private static uint __CachedItems = 0;

		private static uint __WaveTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}