using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.ControlRigSplineImpl")]
	public partial class FControlRigSplineImpl : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.ControlRigSplineImpl");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSplineImpl() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSplineImpl() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSplineImpl A, FControlRigSplineImpl B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSplineImpl A, FControlRigSplineImpl B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSplineImpl;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}