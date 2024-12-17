using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigAnimNodeEventName")]
	public partial class FControlRigAnimNodeEventName : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigAnimNodeEventName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigAnimNodeEventName() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigAnimNodeEventName() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigAnimNodeEventName A, FControlRigAnimNodeEventName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigAnimNodeEventName A, FControlRigAnimNodeEventName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigAnimNodeEventName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName EventName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventName, __InBuffer);
				}
			}
		}

		private static uint __EventName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}