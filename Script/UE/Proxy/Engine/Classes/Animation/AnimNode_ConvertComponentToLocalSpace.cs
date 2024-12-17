using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_ConvertComponentToLocalSpace")]
	public partial class FAnimNode_ConvertComponentToLocalSpace : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_ConvertComponentToLocalSpace");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_ConvertComponentToLocalSpace()
		{
		}

		public static bool operator ==(FAnimNode_ConvertComponentToLocalSpace A, FAnimNode_ConvertComponentToLocalSpace B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_ConvertComponentToLocalSpace A, FAnimNode_ConvertComponentToLocalSpace B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_ConvertComponentToLocalSpace;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FComponentSpacePoseLink ComponentPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentPose, __ReturnBuffer);

					return *(FComponentSpacePoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentPose, __InBuffer);
				}
			}
		}

		private static uint __ComponentPose = 0;

	}
}