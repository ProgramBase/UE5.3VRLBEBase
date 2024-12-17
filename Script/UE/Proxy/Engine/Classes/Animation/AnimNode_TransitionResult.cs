using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_TransitionResult")]
	public partial class FAnimNode_TransitionResult : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_TransitionResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_TransitionResult()
		{
		}

		public static bool operator ==(FAnimNode_TransitionResult A, FAnimNode_TransitionResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_TransitionResult A, FAnimNode_TransitionResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_TransitionResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCanEnterTransition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCanEnterTransition, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCanEnterTransition, __InBuffer);
				}
			}
		}

		private static uint __bCanEnterTransition = 0;

	}
}