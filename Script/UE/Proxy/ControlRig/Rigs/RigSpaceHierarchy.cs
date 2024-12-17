using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigSpaceHierarchy")]
	public partial class FRigSpaceHierarchy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigSpaceHierarchy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigSpaceHierarchy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigSpaceHierarchy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigSpaceHierarchy A, FRigSpaceHierarchy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigSpaceHierarchy A, FRigSpaceHierarchy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigSpaceHierarchy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigSpace> Spaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Spaces, __ReturnBuffer);

					return *(TArray<FRigSpace>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Spaces, __InBuffer);
				}
			}
		}

		private static uint __Spaces = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}