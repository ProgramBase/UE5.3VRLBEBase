using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_MirrorBase")]
	public partial class FAnimNode_MirrorBase : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_MirrorBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_MirrorBase()
		{
		}

		public static bool operator ==(FAnimNode_MirrorBase A, FAnimNode_MirrorBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_MirrorBase A, FAnimNode_MirrorBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_MirrorBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink Source
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Source, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Source, __InBuffer);
				}
			}
		}

		private static uint __Source = 0;

	}
}