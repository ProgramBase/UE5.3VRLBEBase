using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_SingleNode")]
	public partial class FAnimNode_SingleNode : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_SingleNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_SingleNode()
		{
		}

		public static bool operator ==(FAnimNode_SingleNode A, FAnimNode_SingleNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_SingleNode A, FAnimNode_SingleNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_SingleNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink SourcePose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourcePose, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourcePose, __InBuffer);
				}
			}
		}

		private static uint __SourcePose = 0;

	}
}