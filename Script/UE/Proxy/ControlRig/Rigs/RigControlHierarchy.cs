using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigControlHierarchy")]
	public partial class FRigControlHierarchy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigControlHierarchy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigControlHierarchy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigControlHierarchy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigControlHierarchy A, FRigControlHierarchy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigControlHierarchy A, FRigControlHierarchy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigControlHierarchy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigControl> Controls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Controls, __ReturnBuffer);

					return *(TArray<FRigControl>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Controls, __InBuffer);
				}
			}
		}

		private static uint __Controls = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}