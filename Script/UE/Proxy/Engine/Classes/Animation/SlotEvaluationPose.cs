using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SlotEvaluationPose")]
	public partial class FSlotEvaluationPose : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SlotEvaluationPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSlotEvaluationPose() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSlotEvaluationPose() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSlotEvaluationPose A, FSlotEvaluationPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSlotEvaluationPose A, FSlotEvaluationPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSlotEvaluationPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EAdditiveAnimationType AdditiveType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditiveType, __ReturnBuffer);

					return *(EAdditiveAnimationType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditiveType, __InBuffer);
				}
			}
		}

		public float Weight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __InBuffer);
				}
			}
		}

		private static uint __AdditiveType = 0;

		private static uint __Weight = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}