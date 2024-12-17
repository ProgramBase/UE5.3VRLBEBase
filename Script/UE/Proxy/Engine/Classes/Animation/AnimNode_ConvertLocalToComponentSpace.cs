using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_ConvertLocalToComponentSpace")]
	public partial class FAnimNode_ConvertLocalToComponentSpace : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_ConvertLocalToComponentSpace");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_ConvertLocalToComponentSpace()
		{
		}

		public static bool operator ==(FAnimNode_ConvertLocalToComponentSpace A, FAnimNode_ConvertLocalToComponentSpace B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_ConvertLocalToComponentSpace A, FAnimNode_ConvertLocalToComponentSpace B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_ConvertLocalToComponentSpace;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink LocalPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalPose, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalPose, __InBuffer);
				}
			}
		}

		private static uint __LocalPose = 0;

	}
}