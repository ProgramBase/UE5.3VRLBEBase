using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_TransitionPoseEvaluator")]
	public partial class FAnimNode_TransitionPoseEvaluator : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_TransitionPoseEvaluator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_TransitionPoseEvaluator()
		{
		}

		public static bool operator ==(FAnimNode_TransitionPoseEvaluator A, FAnimNode_TransitionPoseEvaluator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_TransitionPoseEvaluator A, FAnimNode_TransitionPoseEvaluator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_TransitionPoseEvaluator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int FramesToCachePose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FramesToCachePose, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FramesToCachePose, __InBuffer);
				}
			}
		}

		public EEvaluatorDataSource DataSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataSource, __ReturnBuffer);

					return *(EEvaluatorDataSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataSource, __InBuffer);
				}
			}
		}

		public EEvaluatorMode EvaluatorMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EvaluatorMode, __ReturnBuffer);

					return *(EEvaluatorMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EvaluatorMode, __InBuffer);
				}
			}
		}

		private static uint __FramesToCachePose = 0;

		private static uint __DataSource = 0;

		private static uint __EvaluatorMode = 0;

	}
}