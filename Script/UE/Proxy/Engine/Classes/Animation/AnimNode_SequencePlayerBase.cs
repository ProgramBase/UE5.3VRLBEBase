using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_SequencePlayerBase")]
	public partial class FAnimNode_SequencePlayerBase : FAnimNode_AssetPlayerBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_SequencePlayerBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_SequencePlayerBase()
		{
		}

		public static bool operator ==(FAnimNode_SequencePlayerBase A, FAnimNode_SequencePlayerBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_SequencePlayerBase A, FAnimNode_SequencePlayerBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_SequencePlayerBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FInputScaleBiasClampState PlayRateScaleBiasClampState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayRateScaleBiasClampState, __ReturnBuffer);

					return *(FInputScaleBiasClampState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayRateScaleBiasClampState, __InBuffer);
				}
			}
		}

		private static uint __PlayRateScaleBiasClampState = 0;

	}
}