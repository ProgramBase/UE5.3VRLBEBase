using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_SecondsToFrames")]
	public partial class FRigVMFunction_SecondsToFrames : FRigVMFunction_AnimBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_SecondsToFrames");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_SecondsToFrames()
		{
		}

		public static bool operator ==(FRigVMFunction_SecondsToFrames A, FRigVMFunction_SecondsToFrames B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_SecondsToFrames A, FRigVMFunction_SecondsToFrames B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_SecondsToFrames;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Seconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Seconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Seconds, __InBuffer);
				}
			}
		}

		public float Frames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frames, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frames, __InBuffer);
				}
			}
		}

		private static uint __Seconds = 0;

		private static uint __Frames = 0;

	}
}