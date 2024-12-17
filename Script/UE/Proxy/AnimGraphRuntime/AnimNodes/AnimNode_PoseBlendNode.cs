using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_PoseBlendNode")]
	public partial class FAnimNode_PoseBlendNode : FAnimNode_PoseHandler, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_PoseBlendNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_PoseBlendNode()
		{
		}

		public static bool operator ==(FAnimNode_PoseBlendNode A, FAnimNode_PoseBlendNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_PoseBlendNode A, FAnimNode_PoseBlendNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_PoseBlendNode;

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

		public EAlphaBlendOption BlendOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendOption, __ReturnBuffer);

					return *(EAlphaBlendOption*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendOption, __InBuffer);
				}
			}
		}

		public UCurveFloat CustomCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomCurve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomCurve, __InBuffer);
				}
			}
		}

		private static uint __SourcePose = 0;

		private static uint __BlendOption = 0;

		private static uint __CustomCurve = 0;

	}
}