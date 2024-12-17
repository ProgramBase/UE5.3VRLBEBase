using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigSettingsPerPinBool")]
	public partial class FControlRigSettingsPerPinBool : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigSettingsPerPinBool");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSettingsPerPinBool() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSettingsPerPinBool() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSettingsPerPinBool A, FControlRigSettingsPerPinBool B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSettingsPerPinBool A, FControlRigSettingsPerPinBool B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSettingsPerPinBool;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, bool> Values
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Values, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Values, __InBuffer);
				}
			}
		}

		private static uint __Values = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}