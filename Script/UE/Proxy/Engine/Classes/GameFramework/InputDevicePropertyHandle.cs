using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDevicePropertyHandle")]
	public partial class FInputDevicePropertyHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InputDevicePropertyHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInputDevicePropertyHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInputDevicePropertyHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInputDevicePropertyHandle A, FInputDevicePropertyHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInputDevicePropertyHandle A, FInputDevicePropertyHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInputDevicePropertyHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint InternalId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InternalId, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InternalId, __InBuffer);
				}
			}
		}

		private static uint __InternalId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}