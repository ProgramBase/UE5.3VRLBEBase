using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.TransformConstraintDescription")]
	public partial class FTransformConstraintDescription : FConstraintDescriptionEx, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.TransformConstraintDescription");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformConstraintDescription()
		{
		}

		public static bool operator ==(FTransformConstraintDescription A, FTransformConstraintDescription B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformConstraintDescription A, FTransformConstraintDescription B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformConstraintDescription;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETransformConstraintType TransformType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformType, __ReturnBuffer);

					return *(ETransformConstraintType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformType, __InBuffer);
				}
			}
		}

		private static uint __TransformType = 0;

	}
}