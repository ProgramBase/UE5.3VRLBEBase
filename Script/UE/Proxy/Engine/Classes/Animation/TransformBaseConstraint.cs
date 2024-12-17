using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TransformBaseConstraint")]
	public partial class FTransformBaseConstraint : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TransformBaseConstraint");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformBaseConstraint() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTransformBaseConstraint() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTransformBaseConstraint A, FTransformBaseConstraint B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformBaseConstraint A, FTransformBaseConstraint B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformBaseConstraint;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigTransformConstraint> TransformConstraints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformConstraints, __ReturnBuffer);

					return *(TArray<FRigTransformConstraint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformConstraints, __InBuffer);
				}
			}
		}

		private static uint __TransformConstraints = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}